using System;
using System.Collections.Generic;
using System.Text;

namespace Skyhop.GribParser.Sections
{
    public class Data : FileReader
    {
        public Data(string file, long startIndex) : base(file, startIndex)
        {
        }
    }
}
