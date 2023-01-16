using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    public class SilverAccount
    {
        public int CalculateRewardPoints(decimal amount)
        {
            return Math.Max((int) decimal.Floor(amount /
            SilverTransactionCostPerPoint), 0);
        }
        private const int SilverTransactionCostPerPoint = 10;
    }
}
