Console.WriteLine("welcome, i will guess a number between 1 and 100 you have 7 guesses. I will tell you if your guess is too high or too low.");
Random random = new Random();
int randomnumber = random.Next(1, 100);
Console.WriteLine("Please enter your guess between 1 and 100:");
if randomnumber < 1 || randomnumber > 100
{
    Console.WriteLine("incorrect number. Please try again.");
}
while (true)
{
    string input = Console.ReadLine();
    int guess;
    if (!int.TryParse(input, out guess))
    {
        Console.WriteLine("Please enter a valid number.");
        continue;
    }
    if (guess < 1 || guess > 100)
    {
        Console.WriteLine("Please enter a number between 1 and 100.");
        continue;
    }
    if (guess < randomnumber)
    {
        Console.WriteLine("Your guess is too low. Try again.");
    }
    else if (guess > randomnumber)
    {
        Console.WriteLine("Your guess is too high. Try again.");
    }
    else
    {
        Console.WriteLine("Congratulations You've guessed the correct number!");
        break;
    }
}

