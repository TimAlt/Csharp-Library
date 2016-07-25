using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Enums
{
	class Program
	{
		enum Players
		{
			JayCutler = 6,
			AlshonJeffery = 17
		}

		static void Main(string[] args)
		{
			Console.WriteLine($"Jay Cutler's number is {(int)Players.JayCutler}.");
			Console.ReadLine();
		}
	}
}
