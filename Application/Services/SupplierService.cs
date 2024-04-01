using Domain.Entities;
using Domain.Repository;

namespace Application.Services
{
    public class SupplierService
    {
        private readonly ISupplierRepository _supplierRepository;
        public SupplierService(ISupplierRepository SupplierRepository)
        {
            _supplierRepository = SupplierRepository;
        }
        public async Task<List<Supplier>> GetAllSuppliers()
        {
            return await _supplierRepository.GetAllAsync();
        }


        public async Task<Supplier> GetSupplierById(int id)
        {
            return await _supplierRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddSupplier(Supplier Supplier)
        {
            await _supplierRepository.AddAsync(Supplier);

            return true;
        }

        public async Task<bool> UpdateSupplier(Supplier Supplier)
        {
            await _supplierRepository.UpdateAsync(Supplier);

            return true;
        }

        public async Task<bool> DeleteSupplier(int id)
        {
            await _supplierRepository.DeleteAsync(id);

            return true;
        }
    }
}
