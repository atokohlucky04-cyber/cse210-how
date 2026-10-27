using System;
namespace exercise1{

class Program
{
    static void Main(string[] args)
    {
        //Ask the user for thier name
        Console.Write("What is your name? ");
        String name = Console.ReadLine();
        // Greet the user Using the variable
        Console.WriteLine($"Hello, {name} ! Welcome to C# programming.");
    }
}
}
    