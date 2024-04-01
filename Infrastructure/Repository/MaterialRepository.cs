using Domain.Entities;
using Domain.Repository;
using Infrastructure.Context;

namespace Infrastructure.Repository
{
    public class MaterialRepository : GenericRepository<Material>, IMaterialRepository
    {
        public MaterialRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
