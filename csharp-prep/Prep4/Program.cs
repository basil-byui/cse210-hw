using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Please enter a number between and enter 0 to quit: " ) ");
            int userResponse = Console.ReadLine();

            userNumber = int.Parse(userResponse);

            // adding the number to the list if it not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }    

        }

        //Part one: Compute the sum
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        console.Writeline($" The sum is: {sum}");


        //Part two: average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($" The average is: {average}");


        //Part three: Find the max
        int max = numbers[0];
        foreach (int number in numbers)
        {
            //If the number found is greater than Max, we have found the needed number.
            if(number > max)
            max = number;

        }


        Console.Writeline($"The max is: {max}");

    }
}