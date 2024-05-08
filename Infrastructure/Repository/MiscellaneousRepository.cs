using Domain.Entities;
using Domain.Repository;
using Infrastructure.Context;

namespace Infrastructure.Repository
{
    public class MiscellaneousRepository : GenericRepository<Miscellaneous>, IMiscellaneousRepository
    {
        public MiscellaneousRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
