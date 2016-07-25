using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Foreach_Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			var nums = new List<int> { 2, 3, 5, 7, 9 };
			var total = 0;

			foreach (int number in nums)
			{
				total += number;
			}

			Console.WriteLine(total);
			Console.ReadLine();
		}
	}
}
