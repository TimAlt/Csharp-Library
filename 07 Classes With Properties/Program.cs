using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes_With_Properties
{
	public class Politician
	{
		public string Name { get; set; }
		public string Party { get; set; }
		public string RunningFor { get; set; }
		public override string ToString()
		{
			return $"{Name} is a {Party} who is running for {RunningFor}.";
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var banks = new Politician();
			banks.Name = "Jim Banks";
			banks.Party = "Republican";
			banks.RunningFor = "Congress";
			Console.WriteLine(banks.ToString());
			Console.ReadLine();
		}
	}
}
