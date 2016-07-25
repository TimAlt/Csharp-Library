using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Conditionals
{
	class Program
	{
		static void Main(string[] args)
		{
			var demCandidate = "Hillary Clinton";
			var indictment = false;

			if (indictment == false)
			{
				Console.WriteLine($"{demCandidate} will be the Democratic Nominee.");
				Console.ReadLine();
			}
		}
	}
}
