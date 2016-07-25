using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Types
{
	class Program
	{
		static void Main(string[] args)
		{
			var demCandidate = "Hillary Clinton";
			var deletedEmails = 20000;

			Console.WriteLine($"{demCandidate} has deleted {deletedEmails} emails.");
			Console.ReadLine();
		}
	}
}
