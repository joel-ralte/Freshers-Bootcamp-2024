using System;
using Zeiss.RiskSystemInterfaceLib;
using Zeiss.RiskSystemInputClassLib;

namespace Zeiss.RiskSystemClassLib
{
    public class RiskReportGenerator : IRiskReportGenerator
    {
        public string GenerateReport(double risk, MergedData mergedData)
        {
            return $"Risk report generated. Risk value: {risk}. Trade ID: {mergedData.Trade.TradeID}, Counterparty ID: {mergedData.Counterparty.CounterpartyID}";
        }
    }
}
