
namespace Refactoring.Interfaces
{
    public interface IRewardCard
    {
        int RewardPoints { get; }

        void CalculateRewardPoints(decimal transactionAmount, decimal accountBalance);
    }
}
