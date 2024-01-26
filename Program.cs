Console.WriteLine("Let's play Guess The Number!");

bool keepPlaying = true;

do
{
    // 1. Ask the player for a range of numbers (done)
    Console.WriteLine("Provide a range of numbers between which you want to guess");

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

    // 2. Random number generator (done)
    Random rng = new Random();
    int generatedNumber = rng.Next(minRange, maxRange + 1);

    // 3. Ask player to provide number (done)
    int amountGuesses = 1;
    Console.WriteLine($"== Attempt: {amountGuesses}");
    Console.WriteLine($"Guess a number between {minRange} and {maxRange}:");
    bool result = int.TryParse(Console.ReadLine()?.Trim(), out int guess);

    // 4. Tell player which attempt it is and if the number is correct/to high/to low (done)

    while (guess != generatedNumber)
    {
        amountGuesses += 1;
        Console.WriteLine($"== Attempt: {amountGuesses}");

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

    // 5. Sum Up if the player guessed
    Console.WriteLine($"You guessed right! It took you {amountGuesses} attempt(s)");

    // 6. Ask if the player wants to play again
    string? providedSign;
    do
    {
    Console.Write("Do you want to play again? (yes/no): ");
    providedSign = Console.ReadLine()?.ToLower().Trim();
    } while (providedSign == "yes" || providedSign == "no");

    if (providedSign == "no")
    {
        keepPlaying = false;
    }

} while (keepPlaying);


Console.WriteLine("Thanks for playing!");
Console.WriteLine("Press any key to continue...");
Console.ReadKey();
