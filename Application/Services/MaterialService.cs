using Domain.Entities;
using Domain.Repository;

namespace Application.Services
{
    public class MaterialService
    {
        private readonly IMaterialRepository _materialRepository;
        public MaterialService(IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository;
        }
        public async Task<List<Material>> GetAllMaterials()
        {
            return await _materialRepository.GetAllAsync();
        }


        public async Task<Material> GetMaterialById(int id)
        {
            return await _materialRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddMaterial(Material Material)
        {
            await _materialRepository.AddAsync(Material);

            return true;
        }

        public async Task<bool> UpdateMaterial(Material Material)
        {
            await _materialRepository.UpdateAsync(Material);

            return true;
        }

        public async Task<bool> DeleteMaterial(int id)
        {
            await _materialRepository.DeleteAsync(id);

            return true;
        }
    }
}
