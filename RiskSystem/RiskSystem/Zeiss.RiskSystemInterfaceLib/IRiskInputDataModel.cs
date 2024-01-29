using System;
using System.Collections.Generic;
using Zeiss.RiskSystemInputClassLib;

namespace Zeiss.RiskSystemInterfaceLib
{
    public interface IRiskInputDataModel
    {
        void CalculateRisk(List<Trade> trades, List<Counterparty> counterparties, double tradeValue, double counterpartyRiskFactor);
    }
}
