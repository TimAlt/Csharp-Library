using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_While_Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			var i = 0;
			while (i < 10)
			{
				i++;
				Console.WriteLine(@"(\ /)");
				Console.WriteLine("( ^-^)");
				Console.WriteLine(@"(("")("")");
				Console.WriteLine();
			}
			Console.ReadLine();
		}
	}
}
