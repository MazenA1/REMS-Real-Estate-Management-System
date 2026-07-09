using Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ImageService : IImageService
    {
        public string SaveImage(string sourceFilePath, string destinationFolder)
        {
            if (string.IsNullOrWhiteSpace(sourceFilePath))
                throw new ArgumentException("Source file path is empty.");

            if (!File.Exists(sourceFilePath))
                throw new FileNotFoundException("Source image not found.", sourceFilePath);

            EnsureFolderExists(destinationFolder);

            string newFileName = GenerateUniqueFileName(sourceFilePath);
            string destinationPath = Path.Combine(destinationFolder, newFileName);

            File.Copy(sourceFilePath, destinationPath, true);

            return destinationPath;
        }

        public bool DeleteImage(string imagePath)
        {
            if (string.IsNullOrWhiteSpace(imagePath))
                return true;

            if (!File.Exists(imagePath))
                return true;

            File.Delete(imagePath);
            return true;
        }

        public string ReplaceImage(string oldImagePath, string newImagePath, string destinationFolder)
        {
            if (oldImagePath == newImagePath)
                return oldImagePath;

            string savedImagePath = SaveImage(newImagePath, destinationFolder);

            DeleteImage(oldImagePath);

            return savedImagePath;
        }

        private void EnsureFolderExists(string folderPath)
        {
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
        }

        private string GenerateUniqueFileName(string sourceFilePath)
        {
            string extension = Path.GetExtension(sourceFilePath);
            return Guid.NewGuid().ToString() + extension;
        }
    }
}
