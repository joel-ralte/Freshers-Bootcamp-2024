using System;
using System.Collections.Generic;
using Zeiss.RiskSystemInputClassLib;

namespace Zeiss.RiskSystemInterfaceLib
{
    public interface IRDSDataReader
    {
        List<Counterparty> ReadRDSData();
    }
}
