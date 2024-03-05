using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your name?");
        String name = Console.ReadLine();

        Console.Write("What is your last name?");
        String lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {lastname},{name},{lastname}");



    }
}