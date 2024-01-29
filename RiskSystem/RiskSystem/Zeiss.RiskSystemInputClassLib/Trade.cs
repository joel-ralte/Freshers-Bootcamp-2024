using System;

namespace Zeiss.RiskSystemInputClassLib
{
    public class Trade
    {
        public string TradeID { get; set; }
        public DateTime Date { get; set; }
        public double CurrentTradeValueUSD { get; set; }
        public string CounterpartyID { get; set; }
    }
}
