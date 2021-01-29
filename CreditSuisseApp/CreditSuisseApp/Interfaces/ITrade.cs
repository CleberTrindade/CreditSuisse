using CreditSuisseApp.Trades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSuisseApp.Interfaces
{
	public interface ITrade
	{
		double Value { get; } 
		string ClientSector { get; } 
		DateTime NextPaymentDate { get; } 

 		string getCategory(Trade trade);
		
	}
}
