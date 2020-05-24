using Skyhop.GribParser.Sections;
using System.IO;

namespace Skyhop.GribParser
{
    public class Record
    {
        private readonly string _fileName;

        private readonly FileStream _fileStream;
        private readonly long _offset;

        public Record(string file, long offset)
        {
            _fileName = file;
            _fileStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
            _offset = offset;
        }

        private Indicator _indicator;
        public Indicator Indicator
        {
            get
            {
                if (_indicator == null)
                {
                    _indicator = new Indicator(_fileName, _offset + 0);
                }

                return _indicator;
            }
        }

        private Identification _identification;

        private long _identificationOffset => _offset + 16;
        private int _identificationSectionLength => Extensions.ReadSectionLength(_fileName, _identificationOffset, 1);

        public Identification Identification
        {
            get
            {
                if (_identification == null && _identificationSectionLength > 0)
                {
                    _identification = new Identification(_fileName, _identificationOffset);
                }
                
                return _identification;
            }
        }

        private LocalUse _localUse;

        private long _localUseOffset => _identificationOffset + _identificationSectionLength;
        private int _localUseSectionLength => Extensions.ReadSectionLength(_fileName, _localUseOffset, 2);

        public LocalUse LocalUse
        {
            get
            {
                if (_localUse == null && _localUseSectionLength > 0)
                {
                    _localUse = new LocalUse(_fileName, _localUseOffset);
                }

                return _localUse;
            }
        }

        private GridDefinition _gridDefinition;

        private long _gridDefinitionOffset => _localUseOffset + _localUseSectionLength;
        private int _gridDefinitionSectionLength => Extensions.ReadSectionLength(_fileName, _gridDefinitionOffset, 3);

        public GridDefinition GridDefinition
        {
            get
            {
                if (_gridDefinition == null && _gridDefinitionSectionLength > 0)
                {
                    _gridDefinition = new GridDefinition(_fileName, _gridDefinitionOffset);
                }

                return _gridDefinition;
            }
        }

        private ProductDefinition _productDefinition;

        private long _productDefinitionOffset => _gridDefinitionOffset + _gridDefinitionSectionLength;
        private int _productDefinitionSectionLength => Extensions.ReadSectionLength(_fileName, _productDefinitionOffset, 4);

        public ProductDefinition ProductDefinition
        {
            get
            {
                if (_productDefinition == null && _productDefinitionSectionLength > 0)
                {
                    _productDefinition = new ProductDefinition(_fileName, _productDefinitionOffset);
                }

                return _productDefinition;
            }
        }

        private DataRepresentation _dataRepresentation;
        private long _dataRepresentationOffset => _productDefinitionOffset + _productDefinitionSectionLength;
        private int _dataRepresentationSectionLength => Extensions.ReadSectionLength(_fileName, _dataRepresentationOffset, 5);

        public DataRepresentation DataRepresentation
        {
            get
            {
                if (_dataRepresentation == null && _dataRepresentationSectionLength > 0)
                {
                    _dataRepresentation = new DataRepresentation(_fileName, _dataRepresentationOffset);
                }

                return _dataRepresentation;
            }
        }

        private BitMap _bitMap;
        private long _bitMapOffset => _dataRepresentationOffset + _dataRepresentationSectionLength;
        private int _bitMapSectionLength => Extensions.ReadSectionLength(_fileName, _bitMapOffset, 6);

        public BitMap BitMap
        {
            get
            {
                if (_bitMap == null && _bitMapSectionLength > 0)
                {
                    _bitMap = new BitMap(_fileName, _bitMapOffset);
                }

                return _bitMap;
            }
        }

        private Data _data;
        private long _dataOffset => _bitMapOffset + _bitMapSectionLength;
        private int _dataSectionLength => Extensions.ReadSectionLength(_fileName, _dataOffset, 7);

        public Data Data
        {
            get
            {
                if (_data == null && _dataSectionLength > 0)
                {
                    _data = new Data(_fileName, _dataOffset);
                }

                return _data;
            }
        }

        // We're not really reading the end bytes as it'll only contain `7777`.
        //public End End { get; set; }
    }
}
