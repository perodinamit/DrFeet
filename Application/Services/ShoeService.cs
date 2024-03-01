using Domain.Entities;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Context;

namespace Application.Services
{
    public class ShoeService : IShoeRepository
    {
        private readonly ApplicationDbContext context;

        public ShoeService(ApplicationDbContext context)
        {
            this.context = context;
        }


        public async Task<List<Shoe>> GetAllShoes()
        {
            return await context.Shoes
                .Include(x => x.Top)
                .Include(x => x.ColorType)
                .Include(x => x.Lining)
                .Include(x => x.Purpose)
                .Include(x => x.Sole)
                .AsSplitQuery()
                .ToListAsync();
        }

        public async Task<Shoe?> FindShoe(int id)
        {
            return await context.Shoes.FindAsync(id);
        }

        public async Task<bool> Delete(int id)
        {
            var toDelete = await context.Shoes.FindAsync(id);

            if (toDelete is null)
            {
                return false;
            }

            context.Shoes.Remove(toDelete);
            context.SaveChanges();

            return true;
        }
    }
}
