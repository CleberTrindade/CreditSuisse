using CreditSuisseApp.Trades.Interfaces;
using System;

namespace CreditSuisseApp.Trades
{
	public class Trade : ITrade
	{

		public double value;
		public string clientSector;
		public DateTime nextPaymentDate;

		public double Value => value;
		public string ClientSector => clientSector;
		public DateTime NextPaymentDate => nextPaymentDate;
		

		public string GetCategory(DateTime referenceDate)
		{
			if (Value == null || ClientSector == null || NextPaymentDate == null) return "Invalid Data";

			var ValidSector = clientSector.Equals("Private") ? true : clientSector.Equals("Public") ? true : false;
			if (!ValidSector) return "Invalid Sector";

			if ((referenceDate.Subtract(nextPaymentDate)).Days > 30) return "DEFAULTED";

			return (Value > 1000000 && ClientSector.Equals("Private")) ? "HIGHRISK" : (Value > 1000000 && ClientSector.Equals("Public")) ? "MEDIUMRISK" : "Undefined category.";
		}
	}
}