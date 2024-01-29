using System;
using System.Collections.Generic;
using Zeiss.RiskSystemInterfaceLib;
using Zeiss.RiskSystemInputClassLib;
using System.Linq;

namespace Zeiss.RiskSystemClassLib
{
    public class RDSTDSDataMerger : IDataMerger
    {
        public List<MergedData> MergeData(List<Trade> trades, List<Counterparty> counterparties)
        {
            List<MergedData> mergedData = new List<MergedData>();
            foreach (var trade in trades)
            {
                Counterparty counterparty = counterparties.FirstOrDefault(c => c.CounterpartyID == trade.CounterpartyID);
                if (counterparty != null)
                {
                    mergedData.Add(new MergedData { Trade = trade, Counterparty = counterparty });
                }
            }
            return mergedData;
        }
    }
}
