using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IImageService
    {
        string SaveImage(string sourceFilePath, string destinationFolder);
        string ReplaceImage(string oldImagePath, string newImagePath, string destinationFolder);
        bool DeleteImage(string imagePath);
    }
}
 