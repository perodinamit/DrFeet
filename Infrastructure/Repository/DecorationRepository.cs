using Domain.Entities;
using Domain.Repository;
using Infrastructure.Context;

namespace Infrastructure.Repository
{
    public class DecorationRepository : GenericRepository<Decoration>, IDecorationRepository
    {
        public DecorationRepository(ApplicationDbContext context) : base(context)
        {
                
        }
    }
}
