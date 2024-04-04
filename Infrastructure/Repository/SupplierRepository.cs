using Domain.Entities;
using Domain.Repository;
using Infrastructure.Context;

namespace Infrastructure.Repository
{
    public class SupplierRepository : GenericRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(ApplicationDbContext context) : base(context)
        {
                
        }
    }
}
