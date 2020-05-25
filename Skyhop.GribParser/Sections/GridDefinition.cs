using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Skyhop.GribParser.Sections
{
    public class GridDefinition : FileReader
    {
        public GridDefinition(string file, long startIndex) : base(file, startIndex)
        {
            if (SectionNumber != 3)
            {
                _sectionLength = 0;
            }
        }

        private int? _sectionLength;
        public int SectionLength
        {
            get
            {
                if (_sectionLength == null)
                {
                    _sectionLength = FileStream.ReadInt(StartIndex);
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
        
        private byte? _gridDefinitionSource;
        public byte GridDefinitionSource
        {
            get
            {
                if (_gridDefinitionSource == null)
                {
                    _gridDefinitionSource = FileStream.ReadByte(StartIndex + 5);
                }

                return _gridDefinitionSource.Value;
            }
        }
        
        private ushort? _dataPoints;
        public ushort DataPoints
        {
            get
            {
                if (_dataPoints == null)
                {
                    _dataPoints = FileStream.ReadUShort(StartIndex + 6);
                }

                return _dataPoints.Value;
            }
        }

        private byte? _optionalNumberListOctetCount;
        public byte OptionalNumberListOctetCount
        {
            get
            {
                if (_optionalNumberListOctetCount == null)
                {
                    _optionalNumberListOctetCount = FileStream.ReadByte(StartIndex + 9);
                }

                return _optionalNumberListOctetCount.Value;
            }
        }

        private byte? _interpretation;
        public byte Interpretation
        {
            get
            {
                if (_interpretation == null)
                {
                    _interpretation = FileStream.ReadByte(StartIndex + 10);
                }

                return _interpretation.Value;
            }
        }

        private short? _gridDefinitionTemplateNumber;
        public short GridDefinitionTemplateNumber
        {
            get
            {
                if (_gridDefinitionTemplateNumber == null)
                {
                    _gridDefinitionTemplateNumber = FileStream.ReadByte(StartIndex + 11);
                }

                return _gridDefinitionTemplateNumber.Value;
            }
        }

        // ToDo: Parse the template
    }
}
