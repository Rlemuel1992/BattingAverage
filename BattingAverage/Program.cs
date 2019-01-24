using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattingAverage
{
	class AtBat
	{

		enum Result { }

		static void Main()
		{
			int atBat;
			int batter;
			double slugPercent;
			double batAvg;
			

			Console.WriteLine("Welcome to Batting Average Calculator");
			Console.WriteLine("How many batters would you like to have?");
			int.TryParse(Console.ReadLine(), out batter);
			int[] batters = new int[batter];

			Console.WriteLine("Enter the number of times at bat 0 - 4");
			int.TryParse(Console.ReadLine(), out atBat);
			bool runBat = true;
			while (runBat == true)
			{
				if (atBat >= 5 || atBat < 0)
				{
					Console.WriteLine("Wrong answer, try again ");
					runBat = true;
				}
				else if (atBat <= 0 || atBat < 5)
				{
					int[] atTheBat = new int[atBat];
					for (int i = 0; i < batters[batter]; i++)
					{
						int.TryParse(Console.ReadLine(), out atTheBat[atBat]);
					}
				}
			}

			Console.WriteLine("Now enter the number of bases scored by each player in descending order from first entered to last.");
			int[] bases = new int[batter];
			for (int i = 0; i < bases[batter]; i++)
			{
				int.TryParse(Console.ReadLine(), out bases[batter]);
			}

			Console.WriteLine(bases[2]);
		}
	}
}
