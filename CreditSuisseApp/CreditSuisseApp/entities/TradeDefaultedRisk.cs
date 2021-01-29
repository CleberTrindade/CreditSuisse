using CreditSuisseApp.Interfaces;
using CreditSuisseApp.Trades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSuisseApp.entities
{
	public class TradeDefaultedRisk : ITrade
	{
		public double Value => throw new NotImplementedException();

		public string ClientSector => throw new NotImplementedException();

		public DateTime NextPaymentDate => throw new NotImplementedException();

		public string getCategory(Trade trade)
		{
			return ((trade.ReferenceDate.Subtract(trade.nextPaymentDate)).Days > 30) ? "DEFAULTED" : "";
		}
	}
}
