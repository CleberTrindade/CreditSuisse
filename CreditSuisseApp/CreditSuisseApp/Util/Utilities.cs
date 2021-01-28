using System;

namespace CreditSuisseApp.Util
{
	public static class Utilities
	{
		public static bool DateValidation(string data)
		{
			try
			{
				DateTime.Parse(data);
				return true;
			}
			catch
			{
				return false;
			}
		}

		public static bool NumericValidation(string info)
		{
			try
			{
				double.Parse(info);
				return true;
			}
			catch
			{
				return false;
			}
		}

		public static string onlyNumeric()
		{
			ConsoleKeyInfo cki;
			string entrada = "";
			bool continuarLoop = true;
			while (continuarLoop)
				if (Console.KeyAvailable)
				{
					cki = Console.ReadKey(true);
					switch (cki.Key)
					{
						case ConsoleKey.Backspace:
							if (entrada.Length == 0) continue;
							entrada = entrada.Remove(entrada.Length - 1);
							Console.Write("\b \b");
							break;
						case ConsoleKey.Enter:
							continuarLoop = false;
							break;
						case ConsoleKey key when ((ConsoleKey.D0 <= key) && (key <= ConsoleKey.D9) ||
												  (ConsoleKey.NumPad0 <= key) && (key <= ConsoleKey.NumPad9)):
							entrada += cki.KeyChar;
							Console.Write(cki.KeyChar);
							break;
					}
				}
			return entrada;
		}

	}
}
