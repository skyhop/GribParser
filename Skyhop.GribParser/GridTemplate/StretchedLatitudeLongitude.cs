using System;
using System.Collections.Generic;
using System.Text;

namespace Skyhop.GribParser.GridTemplate
{
    [GridDefinitionTemplate(TemplateNumber = 2)]
    public class StretchedLatitudeLongitude : LatitudeLongitude
    {
        public StretchedLatitudeLongitude(string file, long startIndex) : base(file, startIndex)
        {
        }

        private int? _southernPoleLatitude;
        public int SouthernPoleLatitude
            => Extensions.SetIfNull(ref _southernPoleLatitude, () => FileStream.ReadInt(73)).Value;

        private int? _southernPoleLongitude;
        public int SouthernPoleLongitude
            => Extensions.SetIfNull(ref _southernPoleLongitude, () => FileStream.ReadInt(77)).Value;

        private int? _projectionRotationAngle;
        public int ProjectionRotationAngle
            => Extensions.SetIfNull(ref _projectionRotationAngle, () => FileStream.ReadInt(81)).Value;
    }
}
