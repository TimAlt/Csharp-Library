using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Functions
{
	class Program
	{
		public static bool isPrime(int zNum)
		{
			if (zNum == 2 || zNum == 3 || zNum == 5)
			{
				return true;
			}
			if (zNum < 7) { return false; }
			if (zNum % 2 == 0)
			{
				return false;
			}

			for (int i = 3; i < zNum; i += 2)
			{
				if (zNum % i == 0)
				{
					return false;
				}
			}

			return true;
		}

		static void Main(string[] args)
		{
			for (int i = 1; i < 100; i++)
			{
				Console.WriteLine($"{i}: {isPrime(i)}");
			}

			Console.ReadLine();
		}


	}
}
