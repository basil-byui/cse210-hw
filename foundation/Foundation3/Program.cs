using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each activity
        var activities = new List<Activity>
        {
            new Running(DateTime.Parse("2023-11-03"), 30, 4.8),   // Running activity
            new Cycling(DateTime.Parse("2023-11-04"), 45, 20),    // Cycling activity
            new Swimming(DateTime.Parse("2023-11-05"), 25, 40)    // Swimming activity
        };

        // Display summary for each activity using polymorphism
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
        

       
    
