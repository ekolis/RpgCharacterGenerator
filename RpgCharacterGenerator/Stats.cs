using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharacterGenerator
{
	/// <summary>
	/// This class stores the set of stats that belong to a character,
	/// or are required to be a character class.
	/// </summary>
	internal class Stats
	{
		/// <summary>
		/// This is a property which stores a character's strength stat.
		/// It is an integer (int) and is public because it needs to be accessible from other code.
		/// The get and set mean that it can both be get (read) and set (written).
		/// </summary>
		public int Strength { get; set; }

		public int Dexterity { get; set; }

		public int Constitution { get; set; }

		public int Intelligence { get; set; }

		public int Wisdom { get; set; }

		public int Charisma { get; set; }

		/// <summary>
		/// This is a computed property.
		/// It uses an arrow syntax with an = followed by a > to show where the return value will be.
		/// Computed properties are read only; you can't set them.
		/// </summary>
		public bool CanBeWarrior
			=> Strength >= 12;

		public bool CanBeRogue
			=> Dexterity >= 12;

		public bool CanBeKnight
			=> Constitution >= 12;

		public bool CanBeMage
			=> Intelligence >= 12;

		public bool CanBePriest
			=> Wisdom >= 12;

		public bool CanBeBard
			=> Charisma >= 12;

		public IEnumerable<string> EligibleRoles
		{
			get
			{
				if (CanBeWarrior)
				{
					yield return "Warrior";
				}
				if (CanBeRogue)
				{
					yield return "Rogue";
				}	
				if (CanBeKnight)
				{
					yield return "Knight";
				}
				if (CanBeMage)
				{
					yield return "Mage";
				}
				if (CanBePriest)
				{
					yield return "Priest";
				}
				if (CanBeBard)
				{
					yield return "Bard";
				}
			}
		}
	}
}
