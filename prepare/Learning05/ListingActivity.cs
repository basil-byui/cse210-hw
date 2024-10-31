// Activities/ListingActivity.cs
using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "What are some of your favorite memories?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Run()
    {
        StartActivity();
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        int itemCount = 0;
        DateTime startTime = DateTime.Now;

        Console.WriteLine("You have the duration to think about items. Please enter your items:");

        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine($"\nYou listed {itemCount} items.");
        EndActivity();
    }
}