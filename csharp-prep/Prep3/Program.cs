using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your magic number? ");
        int valueFromUser = int.Parse(Console.ReadLine());
        
        int guess = -1;

        while (guess != valueFromUser);
        Console.Write("what is your guess? ");
       

        if (guess > valueFromUser)
        {
            Console.WriteLine("guess Lower");
        }

        else if (guess < valueFromUser)
        {
            Console.WriteLine("guess Higher");
        }

        else 
        {
            Console.WriteLine("Well done, You've guessed it right!");
        }
    }
}