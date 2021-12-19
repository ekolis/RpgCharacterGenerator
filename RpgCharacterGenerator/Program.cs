using RpgCharacterGenerator;

// create a hero
var hero = new Stats();

// roll his stats
hero.Strength = Dice.Roll(3, 6);
hero.Dexterity = Dice.Roll(3, 6);
hero.Constitution = Dice.Roll(3, 6);
hero.Intelligence = Dice.Roll(3, 6);
hero.Wisdom = Dice.Roll(3, 6);
hero.Charisma = Dice.Roll(3, 6);

// print his stats
Console.WriteLine("Your hero's stats:");
Console.WriteLine($"Strength: {hero.Strength}");
Console.WriteLine($"Dexterity: {hero.Dexterity}");
Console.WriteLine($"Constitution: {hero.Constitution}");
Console.WriteLine($"Intelligence: {hero.Intelligence}");
Console.WriteLine($"Wisdom: {hero.Wisdom}");
Console.WriteLine($"Charisma: {hero.Charisma}");

Console.WriteLine();

// print list of viable roles
var roles = hero.EligibleRoles.ToList();
if (roles.Any())
{
	Console.WriteLine("This character is viable for the following roles:");
	foreach (var role in roles)
	{
		Console.WriteLine(role);
	}
}
else
{
	Console.WriteLine("This character is not viable for any roles...");
}