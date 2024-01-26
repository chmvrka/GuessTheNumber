Console.WriteLine("Let's play Guess The Number!");

bool keepPlaying = true;

do
{
    Console.WriteLine(Environment.NewLine + "Provide a range of numbers between which you want to guess");

    Console.Write("Minimum: ");
    bool minResult = int.TryParse(Console.ReadLine()?.Trim(), out int minRange);

    Console.Write("Maximum: ");
    bool maxResult = int.TryParse(Console.ReadLine()?.Trim(), out int maxRange);

    if (!minResult || !maxResult || maxRange <= minRange)
    {
        minRange = 0;
        maxRange = 100;
        Console.WriteLine($"I don't get your math so it will be a number between {minRange} and {maxRange}");
    }

    Random rng = new Random();
    int generatedNumber = rng.Next(minRange, maxRange + 1);

    int amountGuesses = 1;
    Console.WriteLine(Environment.NewLine + $"== Attempt: {amountGuesses}");
    Console.WriteLine($"Guess a number between {minRange} and {maxRange}:");
    bool result = int.TryParse(Console.ReadLine()?.Trim(), out int guess);

    while (guess != generatedNumber)
    {
        amountGuesses += 1;
        Console.WriteLine(Environment.NewLine + $"== Attempt: {amountGuesses}");

        if (guess < generatedNumber)
        {
            Console.WriteLine("You guessed wrong, please try something higher:");
        }
        else if (guess > generatedNumber)
        {
            Console.WriteLine("You guessed wrong, please try something lower:");
        }

        int.TryParse(Console.ReadLine()?.Trim(), out guess);
    }

    Console.WriteLine(Environment.NewLine + $"You guessed right! It took you {amountGuesses} attempt(s)");

    string? providedSign;
    do
    {
        Console.Write("Do you want to play again? (yes/no): ");
        providedSign = Console.ReadLine()?.ToLower().Trim();
    } while (providedSign != "yes" && providedSign != "no");

    if (providedSign == "no")
    {
        keepPlaying = false;
    }

} while (keepPlaying);

Console.WriteLine();
Console.WriteLine("Thanks for playing!");
Console.WriteLine("Press any key to continue...");
Console.ReadKey();
