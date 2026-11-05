using Interfaces;
using Models;
using Models.Enum;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services
{

    /// <summary>
    /// Provides file storage operations for the application,
    /// including saving files into configured storage folders,
    /// generating unique file names, and resolving stored file paths.
    /// </summary>
    public class FileStorageServics : IFileStoradeServics
    {
        private readonly string _rootPath = ConfigurationManager.AppSettings["FilesRootPath"];

        private readonly IAppLogger _appLogger; 

        public FileStorageServics(IAppLogger appLogger)
        {
            this._appLogger = appLogger;
        }

        /// <summary>
        /// Saves a file into the specified application storage folder
        /// using a unique generated file name.
        /// </summary>
        /// <param name="sourceFilePath">
        /// The full path of the source file to be saved.
        /// </param>
        /// <param name="folderType">
        /// The destination storage folder category.
        /// </param>
        /// <param name="fileType">
        /// The expected type of the file used for validation.
        /// </param>
        /// <returns>
        /// Information about the stored file, including its original name,
        /// stored name, relative path, extension, and size.
        /// </returns>
        /// <exception cref="ConfigurationErrorsException">
        /// Thrown when the root storage path is not configured.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when the source file path is null, empty, or invalid.
        /// </exception>
        /// <exception cref="FileNotFoundException">
        /// Thrown when the source file does not exist.
        /// </exception>
        public StoredFileResult SaveFile(string sourceFilePath, StorageFolderType folderType, StoredFileType fileType = StoredFileType.Image)
        {
            if (string.IsNullOrWhiteSpace(this._rootPath))
                throw new ConfigurationErrorsException("FilesRootPath is not configured.");

            // check the root path is exist.
            _ensureFolderExists(this._rootPath);

            if (string.IsNullOrWhiteSpace(sourceFilePath))
                throw new ArgumentException(
                "Source file path cannot be null or empty.",
                nameof(sourceFilePath));

            if (!File.Exists(sourceFilePath))
            {
                throw new FileNotFoundException(
                    "The source file was not found.",
                    sourceFilePath);
            }

            //Build the full destination path for the stored file.
            string newFileName = _generateUniqueFileName(sourceFilePath);

            // set destination path folder.
            string destinationPath = Path.Combine(_handleFolderTypeAndGetDestinationPath(folderType), newFileName);

            try
            {
                File.Copy(sourceFilePath, destinationPath, false);
            }
            catch (IOException ex)
            {
                _appLogger.LogError("An error occurred while copying the file.", ex);

                throw;
            }

            return new StoredFileResult() {
                OriginalFileName = Path.GetFileName(sourceFilePath),
                StoredFileName = newFileName,
                Extension = Path.GetExtension(destinationPath),
                RelativePath = Path.Combine(folderType.ToString(), newFileName),
                SizeInBytes = new FileInfo(destinationPath).Length,
            };
        }

        /// <summary>
        /// Ensures that the specified directory exists,
        /// creating it when necessary.
        /// </summary>
        private void _ensureFolderExists(string folderPath)  
        {
            Directory.CreateDirectory(folderPath);
        }

        /// <summary>
        /// Builds and returns the full destination folder path
        /// based on the configured root path and storage folder type.
        /// </summary>
        private string _handleFolderTypeAndGetDestinationPath(StorageFolderType folderType) 
        {

            string destinationPath = string.Empty;
             
            destinationPath = Path.Combine(this._rootPath, folderType.ToString());

            _ensureFolderExists(destinationPath);

            return destinationPath;

        }

        /// <summary>
        /// Generates a unique file name while preserving
        /// the original file extension.
        /// </summary>
        private string _generateUniqueFileName(string sourceFilePath) 
        {
            string extension = Path.GetExtension(sourceFilePath);
            return Guid.NewGuid().ToString() + extension;
        }

        /// <summary>
        /// Deletes a stored file using its relative storage path.
        /// </summary>
        public bool DeleteFile(string relativePath)
        {
            return false;
        }

        /// <summary>
        /// Converts a relative storage path into its full physical path.
        /// </summary>
        public string GetFullPath(string relativePath)
        {
            return string.Empty;
        }

        /// <summary>
        /// Determines whether a file exists at the specified relative storage path.
        /// </summary>
        public bool FileExists(string relativePath)
        {
            return false;
        }

    }
}
