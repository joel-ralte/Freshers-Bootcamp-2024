using System;
using Zeiss.RiskSystemControllerLib;
using Zeiss.RiskSystemClassLib;
using Zeiss.RiskSystemInterfaceLib;
using Zeiss.RiskSystemInputClassLib;

    public class Program
    {
        static void Main(string[] args)
        {
            // Dependency injection
            IRDSDataReader rdsDataReader = new RDSDataReader();
            ITDSDataReader tdsDataReader = new TDSDataReader();
            IDataMerger dataMerger = new RDSTDSDataMerger();
            IRiskCalculator riskCalculator = new RiskCalculator();
            IRiskReportGenerator reportGenerator = new RiskReportGenerator();
            IRiskReportSaver reportSaver = new RiskReportSaver();

            IRiskInputDataModel riskInputDataModel = new RiskInputDataModel(riskCalculator, reportGenerator, reportSaver, dataMerger);

            
            // Controller initialization
            FinanceRiskController controller = new FinanceRiskController(rdsDataReader, tdsDataReader, riskInputDataModel);

            // Run risk analysis with custom parameters
            controller.RunRiskAnalysis(100000, 0.05); // Example parameters: tradeValue = $100,000, counterpartyRiskFactor = 5%

            Console.Read();
        }
    }

