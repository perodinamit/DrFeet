using Domain.Entities;
using Domain.Repository;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class MiscellaneousService
    {
        private readonly IMiscellaneousRepository miscellaneousRepository;

        public MiscellaneousService(IMiscellaneousRepository miscellaneousRepository)
        {
            this.miscellaneousRepository = miscellaneousRepository;
        }


        public async Task<List<Miscellaneous>> GetAllMiscellaneouses()
        {
            return await miscellaneousRepository.GetAllAsync();
        }

        public async Task<Miscellaneous> GetMiscellaneousById(int id)
        {
            return await miscellaneousRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddMiscellaneous(Miscellaneous miscellaneous)
        {
            try
            {
                await miscellaneousRepository.AddAsync(miscellaneous);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> UpdateMiscellaneous(Miscellaneous miscellaneous)
        {
            try
            {
                await miscellaneousRepository.UpdateAsync(miscellaneous);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> DeleteMiscellaneous(int id)
        {
            try
            {
                await miscellaneousRepository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

    }
}
