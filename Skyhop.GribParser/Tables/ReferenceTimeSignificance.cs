namespace Skyhop.GribParser.Tables
{
    public enum ReferenceTimeSignificance
    {
        Analysis = 0,
        StartOfForecast = 1,
        VerifyingTimeOfForecast = 2,
        ObservationTime = 3,
        Missing = 255
    }
}
