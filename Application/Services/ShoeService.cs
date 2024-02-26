using Domain.Entities;
using Domain.Repository;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                .AsSplitQuery()
                .ToListAsync();
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
