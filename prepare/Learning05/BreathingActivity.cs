// Activities/BreathingActivity.cs
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        StartActivity();
        int timeRemaining = Duration;

        while (timeRemaining > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(3);
            timeRemaining -= 3;

            Console.WriteLine("Breathe out...");
            ShowSpinner(3);
            timeRemaining -= 3;
        }
        EndActivity();
    }
}