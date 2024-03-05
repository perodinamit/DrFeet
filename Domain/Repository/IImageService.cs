using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IImageService
    {
        Task<byte[]> UploadImage(IBrowserFile file);
    }
}
