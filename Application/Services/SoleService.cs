using Domain.Entities;
using Domain.Repository;

namespace Application.Services
{
    public class SoleService
    {
        private readonly ISoleRepository soleRepository;

        public SoleService(ISoleRepository soleRepository)
        {
            this.soleRepository = soleRepository;
        }

        public async Task<List<Sole>> GetAllSoles()
        {
            return await soleRepository.GetAllAsync();
        }

        public async Task<Sole> GetSoleById(int id)
        {
            return await soleRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddSole(Sole sole)
        {
            await soleRepository.AddAsync(sole);

            return true;
        }

        public async Task<bool> UpdateSole(Sole sole)
        {
            await soleRepository.UpdateAsync(sole);

            return true;
        }

        public async Task<bool> DeleteSole(int id)
        {
            await soleRepository.DeleteAsync(id);

            return true;
        }
    }
}
//dodati koeficijent za svaku sastavnicu po kojoj će se računati dalje kalkulacija