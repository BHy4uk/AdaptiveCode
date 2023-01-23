
namespace Refactoring.Interfaces
{
    public interface ITradeStorage
    {
        public void Persist(IEnumerable<TradeRecord> trades);
    }
}
