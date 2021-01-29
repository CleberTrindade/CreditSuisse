using CreditSuisseApp.Interfaces;
using CreditSuisseApp.Trades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSuisseApp.entities
{
	public class TradeHighRisk : ITrade
	{
		public double Value { get; private set; }

		public string ClientSector { get; private set; }

		public DateTime NextPaymentDate { get; private set; }

		public string getCategory(Trade trade)
		{
			return (trade.value > 1000000 && trade.clientSector.Equals("Private")) ? "HIGHRISK" : "";
		}
	}
}
