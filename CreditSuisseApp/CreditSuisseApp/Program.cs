using CreditSuisseApp.Commands;
using CreditSuisseApp.entities;
using CreditSuisseApp.Interfaces.Commands;
using CreditSuisseApp.Util;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace CreditSuisseApp
{
	class Program
	{
        private static string dtParam = "";


        static void Main(string[] args)
		{
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var negotiationCommand = serviceProvider.GetService<INegotiationCommand>();


            List<string> dataOutput = new List<string>();

            System.Console.Write("Enter the reference Date: ");
            dtParam = System.Console.ReadLine();
            dateValidation();
            var DtReference = DateTime.Parse(dtParam);

            System.Console.Write("Enter the number of trades: ");
            var total = int.Parse(Utilities.onlyNumeric());
            var inic = 1;
            System.Console.WriteLine("");

            Negotiation negotiation = new Negotiation();
            negotiation.ReferenceDate = DtReference;

            while (inic <= total)
			{
                System.Console.Write("Enter the trading description: ");
                negotiation.DescTrade = System.Console.ReadLine();
                dataOutput.Add(negotiationCommand.GetCategory(negotiation));
                inic++;
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("Sample output:");
            foreach (var item in dataOutput)
			{
                System.Console.WriteLine($"{item}");
            }
            
            Console.ReadKey();
		}

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<INegotiationCommand, NegotiationCommand>();            
        }

        private static void dateValidation()
        {
            var dtValida = Utilities.DateValidation(dtParam);

            while (!dtValida)
            {
                System.Console.Write("Enter Date valid: ");
                dtParam = System.Console.ReadLine();
                dtValida = Utilities.DateValidation(dtParam);
            }
        }        
    }
}

