using CreditSuisseApp.Trades;

namespace CreditSuisseApp.Interfaces.Commands
{
	public interface ITradeCommand
	{
		string GetCategory(Trade trade);
	}
}
