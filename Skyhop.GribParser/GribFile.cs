using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Skyhop.GribParser
{
    public class GribFile
    {
        private readonly string _fileName;

        internal readonly FileStream _fileStream;

        public GribFile(string file)
        {
            _fileName = file;
            _fileStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
        }

        private List<Record> _records = new List<Record>();
        public ReadOnlyCollection<Record> Records
        {
            get
            {
                if (_records.Count == 0)
                {
                    long offset = 0;

                    do
                    {
                        var record = new Record(_fileName, offset);

                        _records.Add(record);

                        offset += record.Indicator.Length;
                    } while (offset < _fileStream.Length);
                }

                return _records.AsReadOnly();
            }
        }
    }
}
