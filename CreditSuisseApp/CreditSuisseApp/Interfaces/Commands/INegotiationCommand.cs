using CreditSuisseApp.entities;

namespace CreditSuisseApp.Interfaces.Commands
{
	public interface INegotiationCommand
	{
		string GetCategory(Negotiation negotiation);

		string DataValidation(string info);
	}
}
