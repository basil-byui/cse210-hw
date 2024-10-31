// Activities/Activity.cs
using System;
using System.Threading;

public abstract class Activity
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"\nStarting {Name}");
        Console.WriteLine(Description);
        
        // Enhanced input handling
        while (true)
        {
            try
            {
                Console.Write("Enter the duration of the activity in seconds: ");
                string input = Console.ReadLine();
                Duration = Convert.ToInt32(input);
                break; // Exit the loop if input is valid
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An I/O error occurred: {ex.Message}");
                return; // Exit the method if an I/O error occurs
            }
        }

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nGood job! You have completed the activity.");
        Console.WriteLine($"Completed: {Name} for {Duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int pauseTime)
    {
        for (int i = 0; i < pauseTime; i++)
        {
            Console.Write("."); // Removed Console.CursorLeft
            Thread.Sleep(1000);
        }
        Console.WriteLine(); // Move to the next line after spinner
    }

    public abstract void Run();
}