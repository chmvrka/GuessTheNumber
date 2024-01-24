using System.ComponentModel;

Console.WriteLine("Let's play Guess The Number!");

// 1. Ask the player for a range of numbers
Console.WriteLine("Provide a range of numbers between which you want to guess");

Console.Write("Minimum: ");
int.TryParse(Console.ReadLine(), out int minRange);

Console.Write("Maximum: ");
int.TryParse(Console.ReadLine(), out int maxRange);

// 2. Random number generator
// 3. Ask player to provide number
Console.WriteLine ($"Guess a number between {minRange} and {maxRange}:");
// 4. Tell player which attempt it is and if the number is correct/to high/to low
// 5. Sum Up if the player guessed
// 6. Ask if the player wants to play again

Console.ReadKey();
