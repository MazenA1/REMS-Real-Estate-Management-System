using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PersonImageService : IPersonImageService
    {
        public bool HandlePersonalImage(Person person, string newImagePath)
        {
            if (person.ImagePath != newImagePath)
            {
                if (!string.IsNullOrEmpty(newImagePath) && _DeleteOldImageFromFile(person.ImagePath))
                {
                    if (FileStorageService.CopyImageToProjectImageFolder(ref newImagePath))
                    {
                        person.ImagePath = newImagePath;
                        return true;
                    }
                    else
                        return false;
                }
            }

            return true;
        }
        public  bool HandelIdImage(Person person, string newIdImagePath)
        {
            if (person.IdPhotoPath != newIdImagePath)
            {
                if (!string.IsNullOrEmpty(newIdImagePath) && _DeleteOldImageFromFile(person.IdPhotoPath))
                {
                    if (FileStorageService.CopyImageToProjectImageFolder(ref newIdImagePath))
                    {
                        person.IdPhotoPath = newIdImagePath;
                        return true;
                    }
                    else
                        return false;
                }
            }

            return true;
        }
        private static bool _DeleteOldImageFromFile(string oldImagePath)
        {
            if (string.IsNullOrWhiteSpace(oldImagePath))
                return true;

            if (!File.Exists(oldImagePath))
                return true;

            try
            {
                File.Delete(oldImagePath);
                return true;
            }
            catch (IOException)
            {
                // Log later
                return false;
            }
        }
    }
}
