
using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
    ) {}

    public void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;
        int interval = 4; // 4 seconds in, 4 seconds out

        while (elapsed < _duration)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(interval);
            elapsed += interval;

            if (elapsed >= _duration) break;

            Console.Write("Now breathe out... ");
            ShowCountdown(interval);
            elapsed += interval;
        }

        DisplayEndingMessage();
    }
}