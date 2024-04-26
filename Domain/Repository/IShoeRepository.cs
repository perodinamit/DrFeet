using Domain.Entities;

namespace Domain.Repository
{
    public interface IShoeRepository
    {
        Task<List<Shoe>> GetAllShoes();
        Task<bool> Delete(int id);
    }
}
