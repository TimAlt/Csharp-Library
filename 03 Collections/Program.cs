using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Collections
{
	class Program
	{
		static void Main(string[] args)
		{
			var nominees = new Dictionary<string, string>
			{
				{ "Republican", "Trump" },
				{ "Democratic", "Clinton" },
				{ "Libertarian", "Johnson" }
			};

			Console.WriteLine($"{nominees["Republican"]}, {nominees["Democratic"]}, and {nominees["Libertarian"]} will be on the ballot in all 50 states.");
			Console.ReadLine();
		}
	}
}
