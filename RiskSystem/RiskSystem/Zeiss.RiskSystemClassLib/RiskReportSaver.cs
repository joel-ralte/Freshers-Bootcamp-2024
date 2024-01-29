using System;
using Zeiss.RiskSystemInterfaceLib;
using Zeiss.RiskSystemInputClassLib;

namespace Zeiss.RiskSystemClassLib
{
    public class RiskReportSaver : IRiskReportSaver
    {
        public void SaveReport(string report)
        {
            Console.WriteLine("Report saved successfully.\n");
        }
    }
}
