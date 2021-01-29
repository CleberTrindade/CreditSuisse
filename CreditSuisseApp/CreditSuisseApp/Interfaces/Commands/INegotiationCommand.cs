using CreditSuisseApp.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSuisseApp.Interfaces.Commands
{
	public interface INegotiationCommand
	{
		string GetCategory(Negotiation negotiation);

		string DataValidation(string info);
	}
}
