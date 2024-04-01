using Domain.Entities;
using Domain.Repository;

namespace Application.Services
{
    public class DecorationService
    {
        private readonly IDecorationRepository _decorationRepository;

        public DecorationService(IDecorationRepository decorationRepository)
        {
            _decorationRepository = decorationRepository;
        }
        public async Task<List<Decoration>> GetAllDecorations()
        {
            return await _decorationRepository.GetAllAsync();
        }


        public async Task<Decoration> GetDecorationById(int id)
        {
            return await _decorationRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddDecoration(Decoration Decoration)
        {
            await _decorationRepository.AddAsync(Decoration);

            return true;
        }

        public async Task<bool> UpdateDecoration(Decoration Decoration)
        {
            await _decorationRepository.UpdateAsync(Decoration);

            return true;
        }

        public async Task<bool> DeleteDecoration(int id)
        {
            await _decorationRepository.DeleteAsync(id);

            return true;
        }
    }
}
