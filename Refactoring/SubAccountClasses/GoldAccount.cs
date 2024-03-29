﻿using System;
using System.Collections.Generic;

namespace Refactoring.SubAccountClasses
{
    public class GoldAccount
    {
        public int CalculateRewardPoints(decimal amount)
        {
            return Math.Max((int)decimal.Floor(Balance /
            GoldBalanceCostPerPoint + amount /
            GoldTransactionCostPerPoint), 0);
        }
        private const int GoldTransactionCostPerPoint = 5;
        private const int GoldBalanceCostPerPoint = 2000;

        public int Balance { get; set; }
    }
}
