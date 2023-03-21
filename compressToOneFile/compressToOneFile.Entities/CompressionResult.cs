using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compressToOneFile.Entities
{
    public class CompressionResult
    {
        public bool IsSuccess { get; set; }
        public string CompressedFilePath { get; set; }
    }
}
