using Domain.Entities;
using Domain.Repository;
using Infrastructure.Context;


namespace Infrastructure.Repository
{
    public class LiningRepository : GenericRepository<Lining>, ILiningRepository
    {
        public LiningRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
