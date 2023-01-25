
namespace Refactoring.Interfaces
{
    public interface ITradeParser
    {
        public IEnumerable<TradeRecord> Parse(IEnumerable<string> tradeData);
    }
}
