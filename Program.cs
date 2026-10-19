Console.WriteLine("Welcome to this number guessing game!!");
Console.WriteLine("The computer will generate a random number between 1 and 100");
Console.WriteLine("You have 7 attempts to guess it");
Console.WriteLine("I will tell you whether your guess was higher or lower than the number");

int highScore = 0;
int score = 0;

int playerGuess = 0;

string playAgain;

while (true)
{
    Random random = new Random();
    int randomNumber = random.Next(1, 100);
    Console.WriteLine(randomNumber);

    bool correct = false;
    int attempt = 1;

    while (true)
    {
        if (attempt > 7)
        {
            break;
        }
        Console.WriteLine($"Please enter your {attempt} number");
        try
        {
            playerGuess = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("\nKindly enter a number");
            continue;
        }
        if (playerGuess > 100 || playerGuess < 1)
        {
            Console.WriteLine("\nA number between 1 and 100");
            continue;
        }
        attempt++;

        if (playerGuess == randomNumber)
        {
            correct = true;
            break;
        }
        else if (playerGuess > randomNumber)
        {
            Console.WriteLine("Too high");
        }
        else
        {
            Console.WriteLine("Too low");
        }

    }
    attempt--;
    if (attempt == 1)
    {
        score = 100;
    }
    else if (attempt == 2 || attempt == 3)
    {
        score = 80;
    }
    else if (attempt == 4 || attempt == 5)
    {
        score = 60;
    }
    else if (attempt == 6 || attempt == 7)
    {
        score = 0;
    }

    if (correct)
    {
        Console.WriteLine("\nCorrect, you win!!");
       

    }
    else
    {
        Console.WriteLine($"\nYou failed, the correct number was {randomNumber}");
    }

    if (highScore < score)
    {
        highScore = score;
    }
    Console.WriteLine($"Your score is {score}");
    Console.WriteLine($"The Highscore is currently {highScore}");

    Console.WriteLine("\nDo you want to play again? (yes or no)");
    while (true)
    {
        playAgain = Console.ReadLine();
        if (playAgain.ToLower() == "yes" || playAgain.ToLower() == "no")
        {
            break;
        }
        else
        {
             Console.WriteLine("Please enter either yes or no");
        }
    }
    if (playAgain.ToLower() == "no")
    {
        Console.WriteLine("Oki, farewell");
        break;
    } 
}
