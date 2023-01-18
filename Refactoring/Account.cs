using Refactoring.Enums;
using Refactoring.Interfaces;

namespace Refactoring
{
    public class Account
    {
        public Account(IRewardCard rewardCard)
        {
            this.rewardCard = rewardCard;
        }
        public decimal Balance
        {
            get;
            private set;
        }
        public void AddTransaction(decimal amount)
        {
            rewardCard.CalculateRewardPoints(amount, Balance);
            Balance += amount;
        }
        private readonly IRewardCard rewardCard;
    }
}
