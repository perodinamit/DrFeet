using Domain.Entities;
using Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class TopService
    {
        private readonly ITopRepository topRepository;

        public TopService(ITopRepository topRepository)
        {
            this.topRepository = topRepository;
        }

        public async Task<IEnumerable<Top>> GetAllTops()
        {
            return await  topRepository.GetAllAsync();
        }

        public async Task<Top> GetTopById(int id)
        {
            return await topRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddTop(Top top)
        {
            await topRepository.AddAsync(top);

            return true;
        }

        public async Task<bool> UpdateTop(Top top)
        {
            await topRepository.UpdateAsync(top);

            return true;
        }

        public async Task<bool> DeleteTop(int id)
        {
            await topRepository.DeleteAsync(id);
            
            return true;
        }
    }
}
