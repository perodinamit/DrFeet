using Domain.Repository;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ApplicationService
    {
        private readonly IApplicationRepository applicationRepository;

        public ApplicationService(IApplicationRepository applicationRepository)
        {
            this.applicationRepository = applicationRepository;
        }

        public async Task<IEnumerable<Domain.Entities.Application>> GetAllApplications()
        {
            return await applicationRepository.GetAllAsync();
        }

        public async Task<Domain.Entities.Application> GetApplicationById(int id)
        {
            return await applicationRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddApplication(Domain.Entities.Application application)
        {
            await applicationRepository.AddAsync(application);

            return true;
        }

        public async Task<bool> UpdateApplication(Domain.Entities.Application application)
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
