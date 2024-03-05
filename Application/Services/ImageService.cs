using Domain.Repository;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ImageService : IImageService
    {
        public async Task<byte[]> UploadImage(IBrowserFile file)
        {
            byte[]? fileContent = new byte[file.Size];
            await file.OpenReadStream(file.Size).ReadAsync(fileContent.AsMemory(0, (Int32)file.Size));

            return fileContent;
        }
    }
}
