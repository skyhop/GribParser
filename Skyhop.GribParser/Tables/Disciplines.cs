using System;
using System.Collections.Generic;
using System.Text;

namespace Skyhop.GribParser.Tables
{
    /// <summary>
    /// This table is used to indicate the discipline of the processed data contained within a GRIB message. This number is coded in octet 7 of section 0 of the GRIB2 message.
    /// </summary>
    public enum Disciplines
    {
        Meteorological = 0,
        Hydrological = 1,
        LandSurface = 2,
        SatelliteRemoteSensing = 3,
        SpaceWeather = 4,

        // 5 - 9 are reserved

        Oceanographic = 10,
        
        // 11 - 191 are reserved
        // 192 254 are reserved for local use

        Missing = 255
    }
}
