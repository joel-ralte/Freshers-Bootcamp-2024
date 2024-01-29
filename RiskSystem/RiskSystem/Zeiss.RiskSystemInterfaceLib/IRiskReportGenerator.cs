using System;
using System.Collections.Generic;
using Zeiss.RiskSystemInputClassLib;

namespace Zeiss.RiskSystemInterfaceLib
{
    public interface IRiskReportGenerator
    {
        string GenerateReport(double risk, MergedData mergedData);
    }
}
