using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMS.UI.Factories
{
    public static class FileStorageService1
    {
        public static bool CreateFolderDoseNotExist(string FolderPath)
        {
            // Check if the folder exists
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
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;
        }
        public static string CreateGuid() 
        {
            Guid guid = Guid.NewGuid();

            return guid.ToString();
        }
        public static string ReplaceFileNameWhithGUID(string SourceFile)
        {
            string FileName = SourceFile;
            FileInfo file = new FileInfo(FileName);
            string Extn = file.Extension;

            return CreateGuid() + Extn;
        }
        public static bool CopyImageToProjectImageFolder(ref string SourceFile)
        {
            string DestinationFolder = @"C:\REMS_Images\";

            if (!CreateFolderDoseNotExist(DestinationFolder))
                return false;

            string DestinationFile = DestinationFolder + ReplaceFileNameWhithGUID(SourceFile);

            try
            {
                File.Copy(SourceFile, DestinationFile, true);
            }
            catch (IOException IOX)
            {
                MessageBox.Show(IOX.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            SourceFile = DestinationFile;
            return true;
        } 
    }
}
 