using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumberGenerator = new Random();
        int magicNumber = randomNumberGenerator.Next(1, 101);

        int guessNumber = 0;
        int howManyTimes = 0;

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            howManyTimes++;
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.Write($"You guessed it!  It took you {howManyTimes} guesses!");
            }
        }
    }
}