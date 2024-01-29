using System;
using Zeiss.RiskSystemInterfaceLib;
using Zeiss.RiskSystemInputClassLib;

namespace Zeiss.RiskSystemClassLib
{
    public class RiskCalculator : IRiskCalculator
    {
        public double CalculateRisk(double tradeValue, double counterpartyRiskFactor)
        {
            Console.WriteLine("Calculating Risk..");
            return tradeValue * counterpartyRiskFactor;
        }
    }
}
