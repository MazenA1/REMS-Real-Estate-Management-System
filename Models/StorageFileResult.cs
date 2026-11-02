using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StoredFileResult
    {
        public string OriginalFileName { get; set; }
        public string StoredFileName { get; set; }
        public string RelativePath { get; set; }
        public string Extension { get; set; }
        public long SizeInBytes { get; set; }
    }
}
