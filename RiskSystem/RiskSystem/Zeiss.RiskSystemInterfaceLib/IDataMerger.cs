using System;
using System.Collections.Generic;
using Zeiss.RiskSystemInputClassLib;

namespace Zeiss.RiskSystemInterfaceLib
{
    public interface IDataMerger
    {
        List<MergedData> MergeData(List<Trade> trades, List<Counterparty> counterparties);
    }
}
