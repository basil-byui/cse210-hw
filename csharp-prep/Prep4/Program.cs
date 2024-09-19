using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (To quit enter 0): ");
            string userResponse = Console.ReadLine();   
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);    
            }
        }


        // calculating the sum:
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("The sume is: " + sum);
    }

}