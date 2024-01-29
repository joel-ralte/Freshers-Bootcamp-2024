using System;
using System.Collections.Generic;

namespace Zeiss.RiskSystemInterfaceLib
{
    public interface IRiskCalculator
    {
        double CalculateRisk(double tradeValue, double counterpartyRiskFactor);
    }
}
