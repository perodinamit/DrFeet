using Domain.Entities;
using Domain.Repository;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Application.Services
{
    public class CalculationService : ICalculationRepository
    {
        private readonly ApplicationDbContext context;

        public CalculationService(ApplicationDbContext context)
        {
            this.context = context;
        }


        public async Task<List<Calculation>> GetAllCalculations(int id)
        {
            return await context.Calculations
                .Where(x => x.ShoeId == id)
                .ToListAsync();
        }

        public async Task<List<CalculationItem>> GetAllCalculationItemsForCalculation(int id)
        {
            return await context.CalculationItems
                .Where(x => x.CalculationId == id)
                .ToListAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var toDelete = await context.Calculations.FindAsync(id);

            if (toDelete is null)
            {
                return false;
            }
            context.Calculations.Remove(toDelete);
            context.SaveChanges();

            return true;
        }

        public async Task<Calculation> FindCalculation(int id)
        {
            var calculation = await context.Calculations
               .Include(x => x.CalculationItems)
               .AsSplitQuery()
               .FirstOrDefaultAsync();

            return calculation;
        }

        public async Task<int> AddCalculation(Calculation newCalculation)
        {
            context.Calculations.Add(newCalculation);
            await context.SaveChangesAsync();

            return newCalculation.Id;
        }

        public async Task<bool> ModifyCalculation(Calculation modifiedCalculation)
        {
            var existingCalculation = await context.Calculations.FindAsync(modifiedCalculation.Id);

            if (existingCalculation == null)
            {
                return false;
            }
            existingCalculation.Price = modifiedCalculation.Price;

            await context.SaveChangesAsync();

            return true;
        }

        public async Task<CalculationItem> FindCalculationItem(int id)
        {
            var calculationItems = await context.CalculationItems.FirstOrDefaultAsync();

            return calculationItems;
        }

        public async Task<bool> DeleteCalculationItem(int id)
        {
            var toDelete = await context.CalculationItems.FindAsync(id);

            if (toDelete is null)
            {
                return false;
            }
            context.CalculationItems.Remove(toDelete);
            context.SaveChanges();

            return true;
        }

        public async Task<bool> AddCalculationItem(CalculationItem newCalculation)
        {
            context.CalculationItems.Add(newCalculation);
            await context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ModifyCalculationItem(CalculationItem modifiedCalculation)
        {
            var existingCalculation = await context.CalculationItems.FindAsync(modifiedCalculation.Id);

            if (existingCalculation == null)
            {
                return false;
            }
            existingCalculation.Type = modifiedCalculation.Type;
            existingCalculation.Description = modifiedCalculation.Description;
            existingCalculation.Price = modifiedCalculation.Price;
            existingCalculation.Normativ = modifiedCalculation.Normativ;
            existingCalculation.Material = modifiedCalculation.Material;
            existingCalculation.Color = modifiedCalculation.Color;

            await context.SaveChangesAsync();

            return true;
        }

        public async Task<List<CalculationItem>> CreateCalcItemsFromShoe(int shoeId, int calcId)
        {
            var shoes = await context.Shoes
                  .Include(x => x.Top)
                  .Include(x => x.ColorType)
                  .Include(x => x.Lining)
                  .Include(x => x.Purpose)
                  .Include(x => x.Sole)
                  .Where(x => x.Id == shoeId)
                  .AsSplitQuery()
                  .ToListAsync();

            var calcItems = new List<CalculationItem>();

            CalculationItem topItem = await CreateTop(calcId, shoes);
            CalculationItem soleItem = await CreateSole(calcId, shoes);
            CalculationItem liningItem = await CreateLining(calcId, shoes);
            CalculationItem decorationItem = await CreateDecoration(calcId, shoes);
            CalculationItem boxItem = await CreateBoxItem(calcId);
            CalculationItem boxTransportItem = await CreateBoxTransportItem(calcId);

            calcItems.Add(topItem);
            calcItems.Add(soleItem);
            calcItems.Add(liningItem);
            calcItems.Add(decorationItem);
            calcItems.Add(boxItem);
            calcItems.Add(boxTransportItem);

            return calcItems;
        }

        private async Task<CalculationItem> CreateBoxTransportItem(int calcId)
        {
            var boxTransportItem = new CalculationItem
            {
                Type = "Box",
                Description = "Transport Box",
                Material = "Paper",
                Color = string.Empty,
                Price = 0.6m,
                Normativ = "kom",
                CalculationId = calcId
            };
            await AddCalculationItem(boxTransportItem);
            return boxTransportItem;
        }

        private async Task<CalculationItem> CreateBoxItem(int calcId)
        {
            var boxItem = new CalculationItem
            {
                Type = "Box",
                Description = "Box Pair",
                Material = "Paper",
                Color = string.Empty,
                Price = 0.2m,
                Normativ = "kom",
                CalculationId = calcId
            };
            await AddCalculationItem(boxItem);
            return boxItem;
        }

        private async Task<CalculationItem> CreateDecoration(int calcId, List<Shoe> shoes)
        {
            var decorationItem = new CalculationItem();
            if (shoes.FirstOrDefault()!.Decoration == null)
            {
                decorationItem.Type = "Decoration";
                decorationItem.Description = "Decoration";
                decorationItem.Price = 0.00m;
                decorationItem.Material = string.Empty;
                decorationItem.Normativ = "";
                decorationItem.Color = string.Empty;
                decorationItem.CalculationId = calcId;
                await AddCalculationItem(decorationItem);
            }
            else
            {
                Decoration decorationShoe = shoes.First().Decoration!;
                decorationItem.Type = "Decoration";
                decorationItem.Description = decorationShoe.Description ?? "Decoration";
                decorationItem.Price = decorationShoe.Material?.Price ?? 0.00m;
                decorationItem.Material = decorationShoe.Material?.Description ?? string.Empty;
                decorationItem.Normativ = "";
                decorationItem.Color = decorationShoe.Material?.ColorType?.Name ?? "";
                decorationItem.CalculationId = calcId;
                await AddCalculationItem(decorationItem);
            }

            return decorationItem;
        }

        private async Task<CalculationItem> CreateLining(int calcId, List<Shoe> shoes)
        {
            var liningItem = new CalculationItem();
            Lining liningShoe = shoes.FirstOrDefault()!.Lining!;
            liningItem.Type = "Lining";
            liningItem.Description = liningShoe.Name ?? "Lining";
            if (liningShoe.Material == null)
            {
                liningItem.Material = string.Empty;
                liningItem.Color = string.Empty;
                liningItem.Price = 0.00m;
            }
            else
            {
                liningItem.Price = liningShoe.Material.Price ?? 0.00m;
                liningItem.Material = liningShoe.Material!.Description ?? string.Empty;
                liningItem.Color = liningShoe.Material?.ColorType?.Name ?? "";
            }

            liningItem.Normativ = "";
            liningItem.CalculationId = calcId;
            await AddCalculationItem(liningItem);
            return liningItem;
        }

        private async Task<CalculationItem> CreateSole(int calcId, List<Shoe> shoes)
        {
            var soleItem = new CalculationItem();
            Sole soleShoe = shoes.FirstOrDefault()!.Sole;
            soleItem.Type = "Sole";
            soleItem.Description = soleShoe.Name ?? "Sole";
            if (soleShoe.Material == null)
            {
                soleItem.Material = string.Empty;
                soleItem.Color = string.Empty;
                soleItem.Price = 0.00m;
            }
            else
            {
                soleItem.Price = soleShoe.Material.Price ?? 0.00m;
                soleItem.Material = soleShoe.Material!.Description ?? string.Empty;
                soleItem.Color = soleShoe.Material?.ColorType?.Name ?? "";
            }
            soleItem.Normativ = "";
            soleItem.CalculationId = calcId;
            await AddCalculationItem(soleItem);
            return soleItem;
        }

        private async Task<CalculationItem> CreateTop(int calcId, List<Shoe> shoes)
        {
            var topItem = new CalculationItem();
            Top topShoe = shoes.FirstOrDefault()!.Top;
            topItem.Type = "Top";
            topItem.Description = topShoe.Description ?? "Top";
            topItem.Price = topShoe.ExpensePerUnit ?? 0.00m;
            if (topShoe.Material == null)
            {
                topItem.Material = string.Empty;
                topItem.Color = string.Empty;
                topItem.Price = 0.00m;
            }
            else
            {
                topItem.Price = topShoe.Material.Price ?? 0.00m;
                topItem.Material = topShoe.Material!.Description ?? string.Empty;
                topItem.Color = topShoe.Material.ColorType.Name;
            }
            topItem.Normativ = "";
            topItem.CalculationId = calcId;
            await AddCalculationItem(topItem);
            return topItem;
        }
    }
}
