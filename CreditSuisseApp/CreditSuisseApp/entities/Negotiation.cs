using CreditSuisseApp.Trades;
using CreditSuisseApp.Util;
using System;
using System.Collections.Generic;

namespace CreditSuisseApp.entities
{
	public class Negotiation
	{
		public DateTime ReferenceDate { get; set; }
		public string DescTrade { get; set; }
		
		public string GetCategory()
		{
			
			var dataValidation = DataValidation(DescTrade);

			if (dataValidation.Length > 0) return dataValidation;

			var fields = DescTrade.Split(" ");
			Trade trade = new Trade();
			trade.value = Convert.ToDouble(fields[0].ToString());
			trade.clientSector = fields[1].ToString().Trim();
			trade.nextPaymentDate = DateTime.Parse(fields[2].ToString());

			return trade.GetCategory(ReferenceDate);
		}

		private string DataValidation(string info)
		{
			var fields = info.Split(" ");

			if (fields.Length != 3) return "Invalid trading data.";

			var validated = Utilities.NumericValidation(fields[0]) ? "" : "Trading Value invalid.";
			validated = Utilities.DateValidation(fields[2]) ? "" : " Date the next pending payment invalid.";
			return validated;
		}
	}
}
