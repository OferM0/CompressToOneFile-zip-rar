using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compressToOneFile.Entities
{
    public class CompressionOptions
    {
        public CompressionLevel CompressionLevel { get; set; }
        //public ArchiveMode ArchiveMode { get; set; }
        public string FileExtension { get; set; }
    }
}
