using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            
            int userNumber = -1;
            while (userNumber != 0)
            {
                Console.Write("Enter number: ");
                string response = Console.ReadLine();
                userNumber = int.Parse(response);
                
                if (userNumber != 0)
                {
                    numbers.Add(userNumber);
                }
            }
            
            // Compute the sum
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is: {sum}");
            
            // Compute the average
            float average = (float)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");
            
            // Find the maximum
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The maximum is: {max}");
        }
    }
}