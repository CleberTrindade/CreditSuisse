using CreditSuisseApp.Interfaces;
using System;

namespace CreditSuisseApp.Trades
{
	public class Trade : ITrade
	{
		public DateTime ReferenceDate { get; set; }
		public double value;
		public string clientSector;
		public DateTime nextPaymentDate;

		public double Value => value;
		public string ClientSector => clientSector;
		public DateTime NextPaymentDate => nextPaymentDate;
				
	}
}