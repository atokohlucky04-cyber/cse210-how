using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for their first name
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            // Prompt the user for their last name
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            // Display the text back in the requested format using string interpolation
            Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.");
        }
    }
}