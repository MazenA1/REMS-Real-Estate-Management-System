using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FileStorageService
    {
        private static readonly string _ImagesFolder = @"C:\REMS_Images"; 
        public static bool CopyImageToProjectImageFolder(ref string SourceFile)
        {

            if (CreateFolderDoseNotExist(_ImagesFolder))
            {
                string DesinationFile = Path.Combine(_ImagesFolder, ReplaceFileNameWithGuid(SourceFile));

                try
                {
                    File.Copy(SourceFile, DesinationFile, true);
                }
                catch (IOException IOX)
                {
                    // Later Logg
                    return false;
                }

                SourceFile = DesinationFile;
                return true;
            }

            return false;
        }

        public static string ReplaceFileNameWithGuid(string SourceFile) 
        {
            string extension = Path.GetExtension(SourceFile);
            return CreateGuid() + extension;
        }
        public static string CreateGuid()
        {
            return Guid.NewGuid().ToString();
        }
        public static bool CreateFolderDoseNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    // If it doesn't exist, create the folder
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    // Log later.
                    return false;
                }
            }

            return true;
        }
    }
}
