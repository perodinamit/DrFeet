using Domain.Entities;
using Domain.Repository;
using Infrastructure.Context;

namespace Infrastructure.Repository
{
    public class TopRepository : GenericRepository<Top>, ITopRepository
    {
        public TopRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
