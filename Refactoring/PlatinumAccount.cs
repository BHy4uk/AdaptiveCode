using Refactoring.Interfaces;

namespace Refactoring
{
    internal class PlatinumRewardCard : IRewardCard
    {
        public int RewardPoints
        {
            get;
            private set;
        }
        public void CalculateRewardPoints(decimal transactionAmount,
        decimal accountBalance)
        {
            RewardPoints += Math.Max((int) decimal.Ceiling(
            (accountBalance / PlatinumBalanceCostPerPoint) +
            (transactionAmount / PlatinumTransactionCostPerPoint)), 0);
        }
        private const int PlatinumTransactionCostPerPoint = 2;
        private const int PlatinumBalanceCostPerPoint = 1000;
    }
}
