using System;
using System.Collections.Generic;
using Zeiss.RiskSystemInterfaceLib;
using Zeiss.RiskSystemInputClassLib;

namespace Zeiss.RiskSystemClassLib
{
    public class RiskInputDataModel : IRiskInputDataModel
    {
        private IRiskCalculator riskCalculator;
        private IRiskReportGenerator reportGenerator;
        private IRiskReportSaver reportSaver;
        private IDataMerger dataMerger;

        public RiskInputDataModel(IRiskCalculator riskCalculator, IRiskReportGenerator reportGenerator, IRiskReportSaver reportSaver, IDataMerger dataMerger)
        {
            this.riskCalculator = riskCalculator;
            this.reportGenerator = reportGenerator;
            this.reportSaver = reportSaver;
            this.dataMerger = dataMerger;
        }

        public void CalculateRisk(List<Trade> trades, List<Counterparty> counterparties, double tradeValue, double counterpartyRiskFactor)
        {
            List<MergedData> mergedData = dataMerger.MergeData(trades, counterparties);

            foreach (var mergedEntry in mergedData)
            {
                double risk = riskCalculator.CalculateRisk(mergedEntry.Trade.CurrentTradeValueUSD, counterpartyRiskFactor);
                string report = reportGenerator.GenerateReport(risk, mergedEntry);
                Console.WriteLine(report);
                reportSaver.SaveReport(report);
            }
        }
    }
}
