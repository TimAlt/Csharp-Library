using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Classes_With_Constructors
{
	public class Player
	{
		public Player(string name, string sport, string team, string position, int number)
		{
			Name = name;
			Sport = sport;
			Team = team;
			Position = position;
			Number = number;

		}

		public string Name { get; set; }
		public string Sport { get; set; }
		public string Team { get; set; }
		public string Position { get; set; }
		public int Number { get; set; }

		public override string ToString()
		{
			return $"{Name} - {Number}";
		}

		public string writeInfo()
		{
			return $"{Name} is a {Position} who plays for the {Team}. {Name}'s number is {Number}.";
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			var antonioBrown = new Player("Antonio Brown", "Football", "Steelers", "wide receiver", 84);
			Console.WriteLine(antonioBrown.writeInfo());
			Console.ReadLine();
		}
	}
}
