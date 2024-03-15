using Domain.Repository;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace Application.Services
{
    public class ImageService : IImageService
    {
        public async Task<byte[]> UploadImage(IBrowserFile file)
        {
            try
            {
                byte[]? fileContent = new byte[file.Size];
                await using (Stream stream = file.OpenReadStream(file.Size))
                {
                    await stream.ReadAsync(fileContent.AsMemory(0, (Int32)file.Size));
                }

                return fileContent;

            }
            catch (Exception ex)
            {
                Log.Error($"Error at {nameof(UploadImage)}:\n {ex.Message} \n InnerMessageError: {ex.InnerException} ");
                throw;
            }
        }
    }
}
