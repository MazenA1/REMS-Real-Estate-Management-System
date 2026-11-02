using Models;
using Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IFileStoradeServics
    {

        StoredFileResult SaveFile(string sourceFilePath, StorageFolderType folderType, StoredFileType fileType);

        bool DeleteFile(string relativePath);

        string GetFullPath(string relativePath);

        bool FileExists(string relativePath);
    }
}
