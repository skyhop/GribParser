using System;
using System.Collections.Generic;
using System.Text;

namespace Skyhop.GribParser.Sections
{
    public class Identification : Section
    {
        public Identification(string file, long startIndex) : base(file, startIndex)
        {

        }

        private uint? _sectionLength;

        public uint SectionLength
        {
            get
            {
                if (_sectionLength == null)
                {
                    _sectionLength = FileStream.ReadUInt(StartIndex + 0);
                }

                return _sectionLength.Value;
            }
        }

        private byte? _sectionNumber;
        public byte SectionNumber
        {
            get
            {
                if (_sectionNumber == null)
                {
                    _sectionNumber = FileStream.ReadByte(StartIndex + 4);
                }

                return _sectionNumber.Value;
            }
        }

        private short? _center;

        /// <summary>
        /// Identification of the originating/generating center
        /// </summary>
        public short Center
        {
            get
            {
                if (_center == null)
                {
                    _center = FileStream.ReadShort(StartIndex + 5);
                }

                return _center.Value;
            }
        }

        private short? _subcenter;

        /// <summary>
        /// Identification of the originating/generating subcenter
        /// </summary>
        public short Subcenter
        {
            get
            {
                if (_subcenter == null)
                {
                    _subcenter = FileStream.ReadShort(StartIndex + 7);
                }

                return _subcenter.Value;
            }
        }

        private byte? _masterTableVersion;

        /// <summary>
        /// GRIB master tables version number (currently 2)
        /// </summary>
        public byte MasterTableVersion
        {
            get
            {
                if (_masterTableVersion == null)
                {
                    _masterTableVersion = FileStream.ReadByte(StartIndex + 9);
                }

                return _masterTableVersion.Value;
            }
        }

        private byte? _localTablesVersion;
        
        /// <summary>
        /// Version number of GRIB local tables used to augment Master Tables
        /// </summary>
        public byte LocalTablesVersion
        {
            get
            {
                if (_localTablesVersion == null)
                {
                    _localTablesVersion = FileStream.ReadByte(StartIndex + 10);
                }

                return _localTablesVersion.Value;
            }
        }

        private byte? _referenceTimeSignificance;

        /// <summary>
        /// Significance of reference time
        /// </summary>
        public byte ReferenceTimeSignificance
        {
            get
            {
                if (_referenceTimeSignificance == null)
                {
                    _referenceTimeSignificance = FileStream.ReadByte(StartIndex + 11);
                }

                return _referenceTimeSignificance.Value;
            }
        }

        private short? _year;
        public short Year
        {
            get
            {
                if (_year == null)
                {
                    _year = FileStream.ReadShort(StartIndex + 12);
                }

                return _year.Value;
            }
        }

        private byte? _month;

        public byte Month
        {
            get
            {
                if (_month == null)
                {
                    _month = FileStream.ReadByte(StartIndex + 14);
                }

                return _month.Value;
            }
        }

        private byte? _day;
        public byte Day
        {
            get
            {
                if (_day == null)
                {
                    _day = FileStream.ReadByte(StartIndex + 15);
                }

                return _day.Value;
            }
        }

        private byte? _hour;
        public byte Hour
        {
            get
            {
                if (_hour == null)
                {
                    _hour = FileStream.ReadByte(StartIndex + 16);
                }

                return _hour.Value;
            }
        }

        private byte? _minute;
        public byte Minute
        {
            get
            {
                if (_minute == null)
                {
                    _minute = FileStream.ReadByte(StartIndex + 17);
                }

                return _minute.Value;
            }
        }

        private byte? _second;
        public byte Second
        {
            get
            {
                if (_second == null)
                {
                    _second = FileStream.ReadByte(StartIndex + 18);
                }

                return _second.Value;
            }
        }

        private byte? _productionStatus;

        /// <summary>
        /// Production Status of Processed data in the GRIB message
        /// </summary>
        public byte ProductionStatus
        {
            get
            {
                if (_productionStatus == null)
                {
                    _productionStatus = FileStream.ReadByte(StartIndex + 19);
                }

                return _productionStatus.Value;
            }
        }

        private byte? _dataType;

        /// <summary>
        /// Type of processed data in this GRIB message
        /// </summary>
        public byte DataType
        {
            get
            {
                if (_dataType == null)
                {
                    _dataType = FileStream.ReadByte(StartIndex + 20);
                }

                return _dataType.Value;
            }
        }
    }
}
