using System;
using System.Collections.Generic;
using System.Text;

namespace Skyhop.GribParser.Tables
{
    public class ShapeReference : TableValue
    {
        public static readonly ShapeReference Spherical_6_367_470 = new ShapeReference(0, "Earth assumed spherical with radius = 6,367,470.0 m");
        public static readonly ShapeReference DynamicSpherical = new ShapeReference(1, "Earth assumed spherical with radius specified (in m) by data producer");
        public static readonly ShapeReference IAU = new ShapeReference(2, "Earth assumed oblate spheroid with size as determined by IAU in 1965 (major axis = 6,378,160.0 m, minor axis = 6,356,775.0 m, f = 1/297.0");
        public static readonly ShapeReference DynamicOblateSpheroidInKilometers = new ShapeReference(3, "Earth assumed oblate spheroid with major and minor axes specified (in km) by data producer");
        public static readonly ShapeReference GRS80 = new ShapeReference(4, "Earth assumed oblate spheroid as defined in IAG-GRS80 model (major axis = 6,378,137.0 m, minor axis = 6,356,752.314 m, f = 1/298.257222101)");
        public static readonly ShapeReference WGS84 = new ShapeReference(5, "Earth assumed represented by WGS84 (as used by ICAO since 1998) (Uses IAG-GRS80 as a basis)");
        public static readonly ShapeReference Spherical_6_371_229 = new ShapeReference(6, "Earth assumed spherical with radius = 6,371,229.0 m");
        public static readonly ShapeReference DynamicOblateSpheroidInMeters = new ShapeReference(7, "Earth assumed oblate spheroid with major and minor axes specified (in m) by data producer");
        public static readonly ShapeReference SphericalRadiusWGS84ReferenceFrame = new ShapeReference(8, "Earth model assumed spherical with radius 6,371,200 m, but the horizontal datum of the resulting Latitude/Longitude field is the WGS84 reference frame");
        public static readonly ShapeReference OSGB = new ShapeReference(9, "Earth represented by the OSGB 1936 Datum, using the Airy_1830 Spheroid, the Greenwich meridian as 0 Longitude, the Newlyn datum as mean sea level, 0 height");

        public ShapeReference(int value, string description)
        : base(value, description)
        {
        }
    }
}
