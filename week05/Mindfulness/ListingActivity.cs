
using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    ) {}

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Count)]} ---");
        Console.Write("\nYou may begin in: ");
        ShowCountdown(5);

        List<string> userItems = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration - 5);

        Console.WriteLine("\nStart listing items (press Enter after each item):");
        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    userItems.Add(input);
                }
            }
        }

        Console.WriteLine($"\nYou listed {userItems.Count} items!");
        DisplayEndingMessage();
    }
}