using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.FileSystemSamples
{
    internal class FileInformation
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public long SizeInBytes { get; set; }
        public double SizeInKB
        {
            get
            {
                return SizeInBytes / 1024D;
            }
        }
        public double SizeInMB
        {
            get
            {
                return SizeInKB / 1024;
            }
        }
        
        [Description("Dosya uzantısı")]
        public string Extension { get; set; }
        public string Drive
        {
            get
            {
                return Path.Substring(0, 3);
            }
        }
    }
}
