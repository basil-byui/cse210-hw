using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // The user provides the magic number

        Console.Write ("What is the magic number? ")
        int magicNumber = int.Parse(Console.ReadLine());

        ConsoleWrite ("What is your guess? ")
        int response = Console.ReadLine();
        
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your Guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.Write("Incorrect, guess higher");    
            }

            else if (magicNumber < guess)
            {
                console.Write("Incorrect, guess lower");
            }

            else
            {
                Console.WriteLine("Your guess is Correct, Well Done");
            }
        }

    }
}