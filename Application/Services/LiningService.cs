using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class LiningService
    {
        private readonly ILiningRepository liningRepository;

        public LiningService(ILiningRepository liningRepository)
        {
            this.liningRepository = liningRepository;
        }
        public async Task<IEnumerable<Top>> GetAllLinings()
        {
            return await liningRepository.GetAllAsync();
        }

        public async Task<Top> GetLiningById(int id)
        {
            return await liningRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddLining(Lining lining)
        {
            await liningRepository.AddAsync(lining);

            return true;
        }

        public async Task<bool> UpdateLining(Lining lining)
        {
            await liningRepository.UpdateAsync(lining);

            return true;
        }

        public async Task<bool> DeleteLining(int id)
        {
            await liningRepository.DeleteAsync(id);

            return true;
        }
    }
}
