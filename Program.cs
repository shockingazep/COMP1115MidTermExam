using System.ComponentModel.Design;
using System.Threading.Tasks.Sources;

console.WriteLine("welcome, i will guess a number between 1 and 100 you have 7 guesses. I will tell you if your guess is too high or too low.");
Random random = new Random();
int randomnumber = random.Next(1, 100);
Console.WriteLine("Please enter your guess between 1 and 100:");
if (randomnumber < 1 || randomnumber > 100)
{
    Console.WriteLine("incorrect number. Please try again.");
}
while (true)
{
    string input = Console.ReadLine();
    int guess;
    if (int.TryParse(input, out guess))
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
int score = 7 - (guess - 1);
    while (score <= 0)
    {
        Console.WriteLine("You ran out of guesses the correct number was " + randomnumber);
        break;
    }
if (score == 7)
    {Console.WriteLine("You guessed the number on your first try! Your score is 100!.");
if (score == 5 || score == 6)
    {Console.Writeline("You guessed the number on your second or third try! Your score is 80!."); }
    }
if (score == 3|| score ==4)
    { Console.Writeline("You guessed the number on your third or fourth try! Your score is 60!."); }
if (score == 1 || score == 2)
    {Console.Writeline("You guessed the number on your fifth or sixth try! Your score is 40!."); }
Console.WriteLine("your score is "+ score);
    Console.Writeline("do you want to play again?");
    if (Console.ReadLine == true)
        randomnumber = random.Next(1, 100);
    else
    {
        Console.WriteLine("Thanks for playing!");
        break;
    }

}