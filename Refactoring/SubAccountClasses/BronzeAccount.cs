using Refactoring.Interfaces;

namespace Refactoring.SubAccountClasses
{
    internal class BronzeRewardCard : IRewardCard
    {
        public int RewardPoints
        {
            get;
            private set;
        }
        public void CalculateRewardPoints(decimal transactionAmount,
        decimal accountBalance)
        {
            RewardPoints += Math.Max((int)decimal.Floor(transactionAmount /
            BronzeTransactionCostPerPoint), 0);
        }
        private const int BronzeTransactionCostPerPoint = 20;
    }
}
