using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
	public static class ConsoleMethods
	{

		public static void WelcomeUser()
		{
			Console.WriteLine("*****************************");
			Console.WriteLine("Welcome to the Guest Book App");
            Console.WriteLine("*****************************");
            Console.WriteLine();
        }

		public static string GetInfoFromConsole(string message)
		{
			Console.Write(message);
			return Console.ReadLine();
		}

	}
}
