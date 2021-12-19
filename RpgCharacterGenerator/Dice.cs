using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharacterGenerator
{
	internal static class Dice
	{
		/// <summary>
		/// Generates random numbers.
		/// </summary>
		private static Random random = new Random();

		/// <summary>
		/// Rolls some dice.
		/// </summary>
		/// <param name="dice">Number of dice.</param>
		/// <param name="sides">Number of sides on each die.</param>
		/// <returns></returns>
		public static int Roll(int dice, int sides)
		{
			int total = 0; // the result that we will return

			// run dice number of times
			for (var i = 0; i < dice; i++)
			{
				// roll a die
				var num = random.Next(sides) + 1;

				// add die roll to total
				total += num;
			}

			return total;
		}
	}
}
