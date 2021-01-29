using CreditSuisseApp.Interfaces.Commands;
using CreditSuisseApp.Trades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSuisseApp.Commands
{
	public class TradeCommand : ITradeCommand
	{
		public string GetCategory(Trade trade)
		{
			if (trade.value <= 0 || trade.ClientSector == null || trade.NextPaymentDate == null) return "Invalid Data";

			var ValidSector = trade.clientSector.Equals("Private") ? true : trade.clientSector.Equals("Public") ? true : false;
			if (!ValidSector) return "Invalid Sector";

			if ((trade.ReferenceDate.Subtract(trade.nextPaymentDate)).Days > 30) return "DEFAULTED";

			return (trade.Value > 1000000 && trade.ClientSector.Equals("Private")) ? "HIGHRISK" : (trade.Value > 1000000 && trade.ClientSector.Equals("Public")) ? "MEDIUMRISK" : "Undefined category.";

		}
	}
}
