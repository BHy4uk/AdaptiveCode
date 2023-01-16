﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    public class PlatinumAccount
    {
        public decimal Balance
        {
            get;
            set;
        }
        public int CalculateRewardPoints(decimal amount)
        {
            return Math.Max((int) decimal.Ceiling(
            (Balance / PlatinumBalanceCostPerPoint) +
            (amount / PlatinumTransactionCostPerPoint)), 0);
        }
        private const int PlatinumTransactionCostPerPoint = 2;
        private const int PlatinumBalanceCostPerPoint = 1000;
    }
}