using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compressToOneFile.Entities
{
    public class CompressionService
    {
        public CompressionResult CompressDirectory(string sourceDirectoryPath, string destinationFilePath, CompressionOptions options)
        {
            string fileExtension = Path.GetExtension(destinationFilePath);
            CompressionLevel compressionLevel = options.CompressionLevel;
            ZipArchiveMode archiveMode = ZipArchiveMode.Create;
            //ArchiveMode archiveMode = options.ArchiveMode;

            if (string.Equals(fileExtension, ".rar", StringComparison.OrdinalIgnoreCase))
            {
                compressionLevel = CompressionLevel.Fastest; 
                archiveMode = ZipArchiveMode.Update;
                //archiveMode = ArchiveMode.Update;
            }

            using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create))
            using (ZipArchive archive = new ZipArchive(destinationStream, archiveMode))
            {
                DirectoryInfo sourceDirectoryInfo = new DirectoryInfo(sourceDirectoryPath);
                CompressDirectory(sourceDirectoryInfo, archive, compressionLevel);
            }

            CompressionResult result = new CompressionResult();
            result.CompressedFilePath = destinationFilePath;
            result.IsSuccess = true;

            return result;
        }

        private void CompressDirectory(DirectoryInfo sourceDirectoryInfo, ZipArchive archive, CompressionLevel compressionLevel)
        {
            foreach (FileInfo fileInfo in sourceDirectoryInfo.GetFiles())
            {
                string entryName = fileInfo.FullName.Substring(sourceDirectoryInfo.FullName.Length + 1); 
                ZipArchiveEntry entry = archive.CreateEntry(entryName, compressionLevel);
                using (Stream entryStream = entry.Open())
                using (FileStream fileStream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read))
                {
                    fileStream.CopyTo(entryStream);
                }
            }

            foreach (DirectoryInfo subdirectoryInfo in sourceDirectoryInfo.GetDirectories())
            {
                CompressDirectory(subdirectoryInfo, archive, compressionLevel);
            }
        }
    }
}
