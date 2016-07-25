using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_For_Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			var prevOne = 1;
			var prevTwo = 0;
			var curr = 0;
			for (int i = 0; i < 20; i++)
			{
				curr = prevOne + prevTwo;
				Console.WriteLine(curr);
				prevTwo = prevOne;
				prevOne = curr;
			}
			Console.ReadLine();
		}
	}
}
