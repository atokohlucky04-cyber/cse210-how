using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call each function, saving return values and passing data as necessary
            DisplayWelcome();

            string userName = PromptUserName();
            int userNumber = PromptUserNumber();

            int squaredNumber = SquareNumber(userNumber);

            DisplayResult(userName, squaredNumber);
        }

        // 1. DisplayWelcome - Displays the message, "Welcome to the Program!"
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // 2. PromptUserName - Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        // 3. PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string response = Console.ReadLine();
            int number = int.Parse(response);
            return number;
        }

        // 4. SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        // 5. DisplayResult - Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}