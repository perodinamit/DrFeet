using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IShoeRepository
    {
        Task<List<Shoe>> GetAllShoes();
        Task<bool> Delete(int id);
    }
}
