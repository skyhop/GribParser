using System;
using System.Collections.Generic;
using System.Text;

namespace Skyhop.GribParser.Tables
{
    public enum DataType
    {
        AnalysisProducts = 0,
        ForecastProducts = 1,
        AnalysisAndForecastProducts = 2,
        ControlForecastProducts = 3,
        PerturbedForecastProducts = 4,
        ControlAndPerturbedForecastProducts = 5,
        ProcessedSatelliteObservations = 6,
        ProcessedRadarObservations = 7,
        EventProbability = 8,
        ExperimentalProducts = 192,
        Missing = 255
    }
}
