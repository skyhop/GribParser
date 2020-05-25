using System;
using System.Collections.Generic;
using System.Text;

namespace Skyhop.GribParser.Sections
{
    public class BitMap : FileReader
    {
        public BitMap(string file, long startIndex) : base(file, startIndex)
        {
        }
    }
}
