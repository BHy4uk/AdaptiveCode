using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    public class GoldAccount
    {
        public decimal Balance
        {
            get;
            set;
        }
        public int CalculateRewardPoints(decimal amount)
        {
            return Math.Max((int) decimal.Floor((Balance /
            GoldBalanceCostPerPoint) + (amount /
            GoldTransactionCostPerPoint)), 0);
        }
        private const int GoldTransactionCostPerPoint = 5;
        private const int GoldBalanceCostPerPoint = 2000;
    }
}
