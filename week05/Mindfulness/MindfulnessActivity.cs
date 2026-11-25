
using System;
using System.Threading;

public class MindfulnessActivity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public MindfulnessActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.Write("\nEnter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] symbols = { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write($"\r{symbols[i % symbols.Length]} ");
            Thread.Sleep(300);
            i++;
        }
        Console.Write("\r   \r"); // Clear line
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}...");
            Thread.Sleep(1000);
            Console.Write("\b\b\b   \b\b\b"); // Erase countdown text
        }
    }
}