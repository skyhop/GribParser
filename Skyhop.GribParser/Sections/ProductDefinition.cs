using System;
using System.Collections.Generic;
using System.Text;

namespace Skyhop.GribParser.Sections
{
    public class ProductDefinition : Section
    {
        public ProductDefinition(string file, long startIndex) : base(file, startIndex)
        {
        }

        private uint? _sectionLength;

        public uint SectionLength
        {
            get
            {
                if (_sectionLength == null)
                {
                    _sectionLength = FileStream.ReadUInt(StartIndex);
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

        private ushort? _coordinateCount;
        public ushort CoordinateCount
        {
            get
            {
                if (_coordinateCount == null)
                {
                    _coordinateCount = FileStream.ReadUShort(StartIndex + 5);
                }

                return _coordinateCount.Value;
            }
        }

        private ushort? _productDefinitionTemplateNumber;
        public ushort ProductDefinitionTemplateNumber
        {
            get
            {
                if (_productDefinitionTemplateNumber == null)
                {
                    _productDefinitionTemplateNumber = FileStream.ReadUShort(StartIndex + 7);
                }

                return _productDefinitionTemplateNumber.Value;
            }
        }

        // ToDo: Read product definition template.
    }
}
