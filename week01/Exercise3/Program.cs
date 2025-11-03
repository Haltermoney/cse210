using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guesses = 0;
        int guess = 0;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);
            guesses++;

            if (guess == number)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {guesses} guesses.");
            }

            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("Higher");
            }
        }


    }
}