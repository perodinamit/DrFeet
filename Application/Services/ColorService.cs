
﻿using Domain.Entities;
using Domain.Repository;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ColorService
    {
        private readonly IColorRepository colorRepository;

        public ColorService(IColorRepository colorRepository)
        {
            this.colorRepository = colorRepository;
        }

        public async Task<IEnumerable<Color>> GetAllColors()
        {
            return await colorRepository.GetAllAsync();
        }

        public async Task<Color> GetColorById(int id)
        {
            return await colorRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddColor(Color color)
        {
            await colorRepository.AddAsync(color);

            return true;
        }

        public async Task<bool> UpdateColor(Color color)
        {
            await colorRepository.UpdateAsync(color);

            return true;
        }

        public async Task<bool> DeleteColor(int id)
        {
            await colorRepository.DeleteAsync(id);

            return true;
        }
    }
}
