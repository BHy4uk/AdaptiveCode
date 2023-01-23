namespace Refactoring.SubAccountClasses
{
    public class SilverAccount
    {
        public int CalculateRewardPoints(decimal amount)
        {
            return Math.Max((int)decimal.Floor(amount /
            SilverTransactionCostPerPoint), 0);
        }
        private const int SilverTransactionCostPerPoint = 10;
    }
}
