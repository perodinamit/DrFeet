using Domain.ViewModels;

namespace Domain.Repository
{
    public interface IPDFGenerator
    {
        Task GeneratePDF(ShoeViewModel viewModel);
    }
}
