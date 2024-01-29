using System;
using System.Collections.Generic;
using Zeiss.RiskSystemClassLib;
using Zeiss.RiskSystemInterfaceLib;
using Zeiss.RiskSystemInputClassLib;

namespace Zeiss.RiskSystemControllerLib
{
    public class FinanceRiskController
    {
        private IRDSDataReader rdsDataReader;
        private ITDSDataReader tdsDataReader;
        private IRiskInputDataModel riskInputDataModel;

        public FinanceRiskController(IRDSDataReader rdsDataReader, ITDSDataReader tdsDataReader, IRiskInputDataModel riskInputDataModel)
        {
            this.rdsDataReader = rdsDataReader;
            this.tdsDataReader = tdsDataReader;
            this.riskInputDataModel = riskInputDataModel;
        }

        public void RunRiskAnalysis(double tradeValue, double counterpartyRiskFactor)
        {
            List<Trade> trades = tdsDataReader.ReadTDSData();
            List<Counterparty> counterparties = rdsDataReader.ReadRDSData();

            List<Trade> sampleTrades = new List<Trade>
            {
                 new Trade { TradeID = "1", Date = DateTime.Now, CurrentTradeValueUSD = 10000, CounterpartyID = "C1" },
                 new Trade { TradeID = "2", Date = DateTime.Now.AddDays(-1), CurrentTradeValueUSD = 15000, CounterpartyID = "C2" },
            };

            List<Counterparty> sampleCounterparties = new List<Counterparty>
            {
                 new Counterparty { CounterpartyID = "C1", Name = "Counterparty 1" },
                 new Counterparty { CounterpartyID = "C2", Name = "Counterparty 2" },
   
            };

            riskInputDataModel.CalculateRisk(sampleTrades, sampleCounterparties, tradeValue, counterpartyRiskFactor);
        }
    }
}
