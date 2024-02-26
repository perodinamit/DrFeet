//using Domain.Entities;
//using Domain.Repository;
//using Infrastructure.Context;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Infrastructure.Repository
//{
//    public class ShoeRepository : IShoeRepository
//    {
//        public ShoeRepository(ApplicationDbContext context) : base(context)
//        {
//        }

//        public async Task<List<Shoe>> GetAllShoes()
//        {
//            return await context.Shoes.Include(x => x.Top).ToListAsync();
//        }
//    }
//}
