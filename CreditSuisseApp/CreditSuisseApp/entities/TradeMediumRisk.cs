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
			return (trade.Value > 1000000 && trade.ClientSector.Equals("Public")) ? "MEDIUMRISK" : "";
		}
	}
}
