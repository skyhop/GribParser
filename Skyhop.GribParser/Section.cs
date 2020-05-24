using System.IO;

namespace Skyhop.GribParser
{
    public abstract class Section
    {
        public FileStream FileStream;
        public long StartIndex;
        
        public long Length { get; set; }
        public byte Number { get; set; }

        /// <summary>
        /// Abstract base class to base the parser of a section on. Supplied properties enable own instantiation of a filestream
        /// </summary>
        /// <param name="file"></param>
        /// <param name="startIndex"></param>
        public Section(string file, long startIndex)
        {
            FileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
            StartIndex = startIndex;
        }

        ~Section()
        {
            FileStream.Dispose();
        }
    }
}
