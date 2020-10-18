using System.IO;
using System.Linq;

namespace BilgeAdam.FileSystemSamples.Helpers
{
    public static class DirectoryHelper
    {
        public static bool IsEmpty(string path)
        {
            var directories = Directory.EnumerateDirectories(path);
            var files = Directory.EnumerateFiles(path);
            return directories.Count() == 0 && 
                   files.Count() == 0;
        }
    }
}
