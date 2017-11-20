using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public class General
    {
        public int DemoAccountPercentage { get; set; }
        public int RealAccountPercentage { get; set; }
        public int ProfitablePercentage { get; set; }
        public int NonProfitablePercentage { get; set; }
        public decimal FundsWon { get; set; }
        public decimal FundsLost { get; set; }
        public decimal AverageDeposit { get; set; }
        public decimal AverageAccountProfit { get; set; }
        public decimal AverageAccountLoss { get; set; }
        public decimal TotalFunds { get; set; }
    }
}
