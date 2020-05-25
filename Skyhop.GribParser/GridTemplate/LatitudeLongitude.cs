using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Skyhop.GribParser.GridTemplate
{
    [GridDefinitionTemplate(TemplateNumber = 0)]
    public class LatitudeLongitude : FileReader
    {
        public LatitudeLongitude(string file, long startIndex) : base(file, startIndex)
        {
        }

        private byte? _shape;
        public byte Shape => Extensions.SetIfNull(ref _shape, () => FileStream.ReadByte(15)).Value;
        
        private byte? _sphericalRadiusScaleFactor;

        /// <summary>
        /// Scale Factor of radius of spherical Earth
        /// </summary>
        public byte SphericalRadiusScaleFactor 
            => Extensions.SetIfNull(ref _sphericalRadiusScaleFactor, () => FileStream.ReadByte(16)).Value;

        private int? _sphericalRadiusScaleValue;

        /// <summary>
        /// Scale value of radius of spherical Earth
        /// </summary>
        public int SphericalRadiusScaleValue 
            => Extensions.SetIfNull(ref _sphericalRadiusScaleValue, () => FileStream.ReadInt(17)).Value;

        private byte? _majorOblateSpheroidAxisScaleFactor;

        /// <summary>
        /// Scale factor of major axis of oblate spheroid Earth
        /// </summary>
        public byte MajorOblateSpheroidAxisScaleFactor 
            => Extensions.SetIfNull(ref _majorOblateSpheroidAxisScaleFactor, () => FileStream.ReadByte(21)).Value;

        private int? _majorOblateSpheroidAxisScaleValue;

        /// <summary>
        /// Scaled value of major axis of oblate spheroid Earth
        /// </summary>
        public int MarjorOblateSpheroidAxisScaleValue 
            => Extensions.SetIfNull(ref _majorOblateSpheroidAxisScaleValue, () => FileStream.ReadInt(22)).Value;


        private byte? _minorOblateSpheroidAxisScaleFactor;

        /// <summary>
        /// Scale factor of minor axis of oblate spheroid Earth
        /// </summary>
        public byte MinorOblateSpheroidAxisScaleFactor 
            => Extensions.SetIfNull(ref _minorOblateSpheroidAxisScaleFactor, () => FileStream.ReadByte(26)).Value;

        private int? _minorOblateSpheroidAxisScaleValue;

        /// <summary>
        /// Scaled value of minor axis of oblate spheroid Earth
        /// </summary>
        public int MinorOblateSpheroidAxisScaleValue 
            => Extensions.SetIfNull(ref _minorOblateSpheroidAxisScaleValue, () => FileStream.ReadInt(27)).Value;

        private int? _numberOfPointsAlongParallel;

        public int NumberOfPointsAlongParallel
            => Extensions.SetIfNull(ref _numberOfPointsAlongParallel, () => FileStream.ReadInt(31)).Value;

        private int? _numberOfPointsAlongMeridian;

        public int NumberOfPointsAlongMeridian
            => Extensions.SetIfNull(ref _numberOfPointsAlongMeridian, () => FileStream.ReadInt(35)).Value;

        private int? _initialProductionDomainAngle;

        public int InitialProductionDomainAngle
            => Extensions.SetIfNull(ref _initialProductionDomainAngle, () => FileStream.ReadInt(39)).Value;

        private int? _basicAngleSubdivisions;

        public int BasicAngleSubdivisions
            => Extensions.SetIfNull(ref _basicAngleSubdivisions, () => FileStream.ReadInt(43)).Value;


        private int? _firstPointLatitude;
        public int FirstPointLatitude
            => Extensions.SetIfNull(ref _firstPointLatitude, () => FileStream.ReadInt(47)).Value;

        private int? _firstPointLongitude;
        public int FirstPointLongitude 
            => Extensions.SetIfNull(ref _firstPointLongitude, () => FileStream.ReadInt(51)).Value;

        private byte? _resolutionComponentFlags;

        public byte ResolutionComponentFlags
            => Extensions.SetIfNull(ref _resolutionComponentFlags, () => FileStream.ReadByte(55)).Value;

        private int? _lastPointLatitude;
        public int LastPointLatitude
            => Extensions.SetIfNull(ref _lastPointLatitude, () => FileStream.ReadInt(56)).Value;

        private int? _lastPointLongitude;
        public int LastPointLongitude
            => Extensions.SetIfNull(ref _lastPointLongitude, () => FileStream.ReadInt(60)).Value;

        private int? _directionIncrementI;
        public int DirectionIncrementI
            => Extensions.SetIfNull(ref _directionIncrementI, () => FileStream.ReadInt(64)).Value;


        private int? _directionIncrementJ;
        public int DirectionIncrementJ
            => Extensions.SetIfNull(ref _directionIncrementJ, () => FileStream.ReadInt(68)).Value;

        private byte? _scanningMode;
        public byte ScanningMode
            => Extensions.SetIfNull(ref _scanningMode, () => FileStream.ReadByte(72)).Value;

    }
}
