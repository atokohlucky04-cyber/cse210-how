using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Core Requirement 3: Generate a random number from 1 to 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;

            // Core Requirement 2: Add a loop that keeps looping as long as the guess does not match the magic number
            while (guess != magicNumber)
            {
                // Core Requirement 1: Ask the user for a guess
                Console.Write("What is your guess? ");
                string answer = Console.ReadLine();
                guess = int.Parse(answer);

                // Core Requirement 1: Determine if the user needs to guess higher or lower using if statements
                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
        }
    }
}