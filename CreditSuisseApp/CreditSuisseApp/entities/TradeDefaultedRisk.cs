using CreditSuisseApp.Interfaces;
using CreditSuisseApp.Trades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSuisseApp.entities
{
	public class TradeDefaultedRisk : ITrade
	{
		public double Value { get; private set; }

		public string ClientSector { get; private set; }

		public DateTime NextPaymentDate { get; private set; }

		public string getCategory(Trade trade)
		{
			return ((trade.ReferenceDate.Subtract(trade.NextPaymentDate)).Days > 30) ? "DEFAULTED" : "";
		}
	}
}
