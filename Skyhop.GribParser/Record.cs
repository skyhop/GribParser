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
        public Identification Identification
        {
            get
            {
                if (_identification == null)
                    _identification = new Identification(_fileName, _offset + 16);

                if (_identification.SectionNumber == 1)
                    return _identification;

                return null;
            }
        }

        private LocalUse _localUse;
        public LocalUse LocalUse
        {
            get
            {
                if (_localUse == null)
                    _localUse = new LocalUse(
                        _fileName,
                        _offset 
                        + 16
                        + (Identification?.SectionLength ?? 0)
                    );

                if (_localUse.Number == 2)
                    return _localUse;

                return null;
            }
        }

        private GridDefinition _gridDefinition;
        public GridDefinition GridDefinition
        {
            get
            {
                if (_gridDefinition == null)
                    _gridDefinition = new GridDefinition(
                        _fileName,
                        _offset
                        + 16
                        + (Identification?.SectionLength ?? 0)
                        + (LocalUse?.Length ?? 0)
                    );

                if (_gridDefinition.SectionNumber == 3)
                    return _gridDefinition;

                return null;
            }
        }

        private ProductDefinition _productDefinition;
        public ProductDefinition ProductDefinition
        {
            get
            {
                if (_productDefinition == null)
                {
                    _productDefinition = new ProductDefinition(
                        _fileName,
                        _offset
                        + 16
                        + (Identification?.SectionLength ?? 0)
                        + (LocalUse?.Length ?? 0)
                        + (GridDefinition?.StartIndex ?? 0)
                    );
                }

                if (_productDefinition.SectionNumber == 4)
                {
                    return _productDefinition;
                }

                return null;
            }
        }

        public DataRepresentation DataRepresentation { get; set; }
        public BitMap BitMap { get; set; }
        public Data Data { get; set; }
        public End End { get; set; }
    }
}
