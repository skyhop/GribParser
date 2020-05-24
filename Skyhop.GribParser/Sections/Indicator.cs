using Skyhop.GribParser.Tables;
using System.IO;

namespace Skyhop.GribParser.Sections
{
    /// <summary>
    /// This section serves to identify the start of the record in a human readable form, indicate the total length of the message, and indicate the Edition number of GRIB used to construct or encode the message. For GRIB2, this section is always 16 octets long.
    /// </summary>
    public class Indicator : Section
    {
        public Indicator(string file, long startIndex) : base(file, startIndex)
        {

        }

        private Disciplines? _disciplines;
        public Disciplines Discipline
        {
            get
            {
                if (_disciplines == null)
                {
                    _disciplines = (Disciplines)FileStream.ReadByte(StartIndex + 6);
                }

                return _disciplines.Value;
            }
        }


        private byte? _edition;
        /// <summary>
        /// Edition number - 2 for GRIB2
        /// </summary>
        public byte Edition
        {
            get
            {
                if (_edition == null)
                {
                    _edition = FileStream.ReadByte(StartIndex + 7);
                }

                return _edition.Value;
            }
        }

        private long? _length;

        /// <summary>
        /// Total length of GRIB message in octets
        /// </summary>
        public long Length
        {
            get
            {
                if (_length == null)
                {
                    _length = FileStream.ReadLong(StartIndex + 8);
                }

                return _length.Value;
            }
        }
    }
}
