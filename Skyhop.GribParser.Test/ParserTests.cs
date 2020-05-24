using Xunit;
using Skyhop.GribParser.Sections;

namespace Skyhop.GribParser.Test
{
    public class ParserTests
    {
        [Fact]
        public void RecordCount()
        {
            var gribFile = new GribFile(Common.TestFile);

            Assert.True(gribFile.Records.Count == 111);
        }

        [Fact]
        public void ParseIndicatorSection()
        {
            var indicator = new Indicator(Common.TestFile, 0);

            Assert.True(indicator.Discipline == Tables.Disciplines.Meteorological, "Discipline is not meteorological");
            Assert.True(indicator.Edition == 2, "GRIB Edition is not 2");
            Assert.True(indicator.Length == 644548, "GRIB File length is invalid");   
        }

        [Fact]
        public void ParseIdentificationSection()
        {
            var identification = new Identification(Common.TestFile, 16);

            Assert.True(identification.SectionLength == 21);
            Assert.True(identification.SectionNumber == 1);
            Assert.True(identification.Center == 7);
            Assert.True(identification.Subcenter == 0);

            Assert.True(identification.MasterTableVersion == 2);
            Assert.True(identification.LocalTablesVersion == 1);
            Assert.True(identification.ReferenceTimeSignificance == 1);
            Assert.True(identification.Year == 2020);
            Assert.True(identification.Month == 5);
            Assert.True(identification.Day == 14);
            Assert.True(identification.Hour == 6);
            Assert.True(identification.Minute == 0);
            Assert.True(identification.Second == 0);
            Assert.True(identification.ProductionStatus == 0);
            Assert.True(identification.DataType == 1);
        }

        [Fact]
        public void ParseLocalUseSection()
        {
            var identification = new Identification(Common.TestFile, 16);
            var localUse = new LocalUse(Common.TestFile, 16 + identification.SectionLength);

            Assert.True(localUse.Length == 72);
            Assert.True(localUse.Number == 3);
        }

        [Fact]
        public void ParseGridDefinitionSection()
        {
            var identification = new Identification(Common.TestFile, 16);
            var localUse = new LocalUse(Common.TestFile, 16 + identification.SectionLength);

            var gridDefinition = new GridDefinition(Common.TestFile, 16 + identification.SectionLength + localUse.Length);
        }
    }
}
