using System;
using System.Collections.Generic;
using System.Text;

namespace Skyhop.GribParser.Tables
{
    public enum ProductionStatus
    {
        OperationalProducts = 0,
        OperationalTestProducts = 1,
        ResearchProducts = 2,
        ReAnalysisProducts = 3,
        Tigge = 4,
        TiggeTest = 5,
        S2SOperationalProducts = 6,
        S2STestProducts = 7,
        Uerra = 8,
        UerraTest = 9,
        Missing = 255
    }
}
