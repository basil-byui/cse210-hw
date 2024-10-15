using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a reference and scripture
        Reference reference = new Reference("Proverb", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding";


        //Create a Scripture object
        Scripture scripture = new Scripture(reference, scriptureText);

        // Main loop.
        while(true)
        {
            
            Console.WriteLine(scripture.GetDisplayText());

            if(scripture.IsCompletelyHidden()) //Check if all words are hidden
            {
                Console.WriteLine("\nAll words are hidden. Program will now end.");
                break;
            }


            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }
        
            scripture.HideRandomWords(3); // Hide a few random words

        }

    }  
}