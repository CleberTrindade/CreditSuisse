using CreditSuisseApp.Interfaces;
using CreditSuisseApp.Trades;
using System;

namespace CreditSuisseApp.entities
{
	public class TradeMediumRisk : ITrade
	{
		public double Value { get; private set; }

		public string ClientSector { get; private set; }

		public DateTime NextPaymentDate { get; private set; }

		public string getCategory(Trade trade)
		{
			return (trade.value > 1000000 && trade.clientSector.Equals("Public")) ? "MEDIUMRISK" : "";
		}
	}
}
