using System;
using System.Collections.Generic;
using System.Text;

namespace Skyhop.GribParser.Sections
{
    public class LocalUse : Section
    {
        public LocalUse(string file, long startIndex) : base(file, startIndex)
        {
        }

        private int? _length;
        public int Length
        {
            get
            {
                if (_length == null)
                {
                    _length = FileStream.ReadInt(StartIndex + 0);
                }

                return _length.Value;
            }
        }

        private byte? _number;
        public byte Number
        {
            get
            {
                if (_number == null)
                {
                    _number = FileStream.ReadByte(StartIndex + 4);
                }

                return _number.Value;
            }
        }
    }
}
