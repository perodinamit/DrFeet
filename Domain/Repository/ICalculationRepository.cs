using Domain.Entities;

namespace Domain.Repository
{
    public interface ICalculationRepository
    {
        Task<Calculation> FindCalculation(int id);
        Task<bool> Delete(int id);
        Task<CalculationItem> FindCalculationItem(int id);
        Task<bool> DeleteCalculationItem(int id);
        Task<bool> AddCalculationItem(CalculationItem newCalculation);
        Task<bool> ModifyCalculationItem(CalculationItem modifiedCalculation);
        Task<List<CalculationItem>> GetAllCalculationItemsForCalculation(int id);
        Task<List<Calculation>> GetAllCalculations(int id);
    }
}
