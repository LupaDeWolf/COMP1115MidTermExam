Console.WriteLine("Welcome to this number guessing game!!");
Console.WriteLine("The computer will generate a random number between 1 and 100");
Console.WriteLine("You have 7 attempts to guess it");
Console.WriteLine("I will tell you whether your guess was higher or lower than the number");


Random random = new Random();
int randomNumber = random.Next(1, 100);
Console.WriteLine(randomNumber);


int attempt = 1;
int playerGuess = 0;
bool correct = false;

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
    }
    attempt++;

    if (playerGuess == randomNumber)
    {
        correct = true;
        break;
    } else if (playerGuess > randomNumber)
    {
        Console.WriteLine("Too high");
    }
    else
    {
        Console.WriteLine("Too low");
    }

}

if (correct)
{
    Console.WriteLine("Correct, you win!!");
}
