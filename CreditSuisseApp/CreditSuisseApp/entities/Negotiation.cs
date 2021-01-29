using System;

namespace CreditSuisseApp.entities
{
	public class Negotiation
	{
		public DateTime ReferenceDate { get; set; }
		public string DescTrade { get; set; }

		public Negotiation() { }
		public Negotiation(DateTime referenceDate, string descTrade)
		{
			ReferenceDate = referenceDate;
			DescTrade = descTrade;
		}

	}
}
