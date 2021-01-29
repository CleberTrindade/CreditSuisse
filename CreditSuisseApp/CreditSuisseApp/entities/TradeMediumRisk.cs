using CreditSuisseApp.Interfaces;
using CreditSuisseApp.Trades;
using System;

namespace CreditSuisseApp.entities
{
	public class TradeMediumRisk : ITrade
	{
		public double Value => throw new NotImplementedException();

		public string ClientSector => throw new NotImplementedException();

		public DateTime NextPaymentDate => throw new NotImplementedException();

		public string getCategory(Trade trade)
		{
			return (trade.value > 1000000 && trade.clientSector.Equals("Public")) ? "MEDIUMRISK" : "";
		}
	}
}
