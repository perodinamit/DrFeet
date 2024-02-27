using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ApplicationService
    {
        private readonly IApplicationService applicationRepository;

        public ApplicationService(IApplicationService applicationRepository)
        {
            this.applicationRepository = applicationRepository;
        }

        public async Task<IEnumerable<Application>> GetAllApplications()
        {
            return await applicationRepository.GetAllAsync();
        }

        public async Task<Application> GetApplicationById(int id)
        {
            return await applicationRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddApplication(Application application)
        {
            await applicationRepository.AddAsync(application);

            return true;
        }

        public async Task<bool> UpdateApplication(Application application)
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
