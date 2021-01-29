using CreditSuisseApp.entities;
using CreditSuisseApp.Interfaces;
using System;
using System.Collections.Generic;

namespace CreditSuisseApp.Trades
{
	public class Trade : ITrade
	{
		public DateTime ReferenceDate { get; private set; }
		public double Value { get; private set; }
		public string ClientSector { get; private set; }
		public DateTime NextPaymentDate { get; private set; }

		public List<ITrade> tradeCategories = new List<ITrade>()
		{
			new TradeDefaultedRisk(),
			new TradeMediumRisk(),
			new TradeHighRisk()
		};

		public Trade() { }
		public Trade(
			DateTime _referenceDate,
			double _value,
			string _clientSector,
			DateTime _nextPaymentDate)
		{
			ReferenceDate = _referenceDate;
			Value = _value;
			ClientSector = _clientSector;
			NextPaymentDate = _nextPaymentDate;
		}

		public string getCategory(Trade trade)
		{
			var category = "";

			foreach (var _trade in tradeCategories)
			{
				if (category.Equals(""))
					category = _trade.getCategory(trade).Equals("") ? "" : _trade.getCategory(trade);
			}

			return category.Equals("") ? "Undefined category." : category;
		}
	};
}
