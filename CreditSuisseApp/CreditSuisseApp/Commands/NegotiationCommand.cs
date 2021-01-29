using CreditSuisseApp.entities;
using CreditSuisseApp.Interfaces.Commands;
using CreditSuisseApp.Trades;
using CreditSuisseApp.Util;
using System;

namespace CreditSuisseApp.Commands
{
	public class NegotiationCommand : INegotiationCommand
	{

		private readonly ITradeCommand _tradeCommand;
		public NegotiationCommand(ITradeCommand tradeCommand)
		{
			_tradeCommand = tradeCommand;
		}

		public string GetCategory(Negotiation negotiation)
		{
			var dataValidation = DataValidation(negotiation.DescTrade);

			if (dataValidation.Length > 0) return dataValidation;

			var fields = negotiation.DescTrade.Split(" ");
			Trade trade = new Trade();
			trade.ReferenceDate = negotiation.ReferenceDate;
			trade.value = Convert.ToDouble(fields[0].ToString());
			trade.clientSector = fields[1].ToString().Trim();
			trade.nextPaymentDate = DateTime.Parse(fields[2].ToString());

			return _tradeCommand.GetCategory(trade);
		}

		public string DataValidation(string info)
		{
			var fields = info.Split(" ");

			if (fields.Length != 3) return "Invalid trading data.";

			var validated = Utilities.NumericValidation(fields[0]) ? "" : "Trading Value invalid.";
			validated = Utilities.DateValidation(fields[2]) ? "" : " Date the next pending payment invalid.";
			return validated;
		}
	}
}
