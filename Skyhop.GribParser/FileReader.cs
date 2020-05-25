using System.IO;

namespace Skyhop.GribParser
{
    public abstract class FileReader
    {
        public FileStream FileStream;
        public long StartIndex;
        
        /// <summary>
        /// Abstract base class to base the parser of a section on. Supplied properties enable own instantiation of a filestream
        /// </summary>
        /// <param name="file"></param>
        /// <param name="startIndex"></param>
        public FileReader(string file, long startIndex)
        {
            FileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
            StartIndex = startIndex;
        }

        ~FileReader()
        {
            FileStream.Dispose();
        }
    }
}
