using Refactoring.Enums;

namespace Refactoring
{
    public abstract class AccountBase
    {
        public decimal Balance
        {
            get;
            private set;
        }
        public int RewardPoints
        {
            get;
            private set;
        }
        public void AddTransaction(decimal amount)
        {
            RewardPoints += CalculateRewardPoints(amount);
            Balance += amount;
        }
        public abstract int CalculateRewardPoints(decimal amount);
    }
}
