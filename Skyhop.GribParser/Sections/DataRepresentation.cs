﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Skyhop.GribParser.Sections
{
    public class DataRepresentation : FileReader
    {
        public DataRepresentation(string file, long startIndex) : base(file, startIndex)
        {
        }
    }
}
