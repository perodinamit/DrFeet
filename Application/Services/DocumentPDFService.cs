using Domain.Repository;
using Domain.ViewModels;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Application.Services
{
    public class DocumentPDFService : IPDFGenerator
    {
        public Task GeneratePDF(ShoeViewModel viewModel)
        {
            Document.Create(document =>
            {
                // pukne ako ima "Ć Č" i ostala slova sa kvačicama u tekstu, zato treba staviti ovaj fallback
                var textStyle = TextStyle.Default.Fallback(x => x.FontFamily("Times New Roman"));

                document.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.DefaultTextStyle(textStyle);

                    page.Header()
                    .Text($"Date: {DateTime.Now.ToShortDateString()}");

                    page.Content().Padding(50).MaxWidth(300).MinHeight(300)
                    .Column(column =>
                    {
                        column.Spacing(5);

                        if (viewModel?.ImageData?.Length > 0)
                        {
                            column.Item().Image(viewModel.ImageData);

                        }

                        column.Item().Text(text =>
                        {
                            text.Line($"Code: {viewModel.Code}");
                        });

                        column.Item().Text(text =>
                        {
                            text.Line($"Name: {viewModel.Name}");
                        });

                        column.Item().Text(text =>
                        {
                            text.DefaultTextStyle(textStyle);
                            text.Line($"Color: {viewModel.ColorName}");
                        });
                    });
                });
            }).GeneratePdfAndShow();

            return Task.CompletedTask;
        }

    }
}
