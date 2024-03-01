using Domain.Repository;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PurposeService
    {
        private readonly IPurposeRepository applicationRepository;

        public PurposeService(IPurposeRepository applicationRepository)
        {
            this.applicationRepository = applicationRepository;
        }

        public async Task<IEnumerable<Domain.Entities.Purpose>> GetAllApplications()
        {
            return await applicationRepository.GetAllAsync();
        }

        public async Task<Domain.Entities.Purpose> GetApplicationById(int id)
        {
            return await applicationRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddApplication(Domain.Entities.Purpose application)
        {
            await applicationRepository.AddAsync(application);

            return true;
        }

        public async Task<bool> UpdateApplication(Domain.Entities.Purpose application)
        {
            await applicationRepository.UpdateAsync(application);

            return true;
        }

        public async Task<bool> DeleteApplication(int id)
        {
            await applicationRepository.DeleteAsync(id);

            return true;
        }
    }
}
