using System;

class Program
{
    static void Main(string[] args)
    { 
        Journal theJournal = new Journal();                            //Create a new journal object.
        PromptGenerator promptGenerator = new PromptGenerator();       //Create a new prompt generator

        while (true)
        {
            Console.WriteLine("\n---Welcome to the Journal Manu---");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("what would you like to do?, Choose an option: ");
            string choice = Console.ReadLine();                        // Read user input

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt(); //Get random prompt
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();              //Capture user response

                    Entry newEntry = new Entry(prompt, response);     //Create a new entry
                    theJournal.AddEntry(newEntry);                    //Add the entry to the journal.
                    break;

                case "2":
                    theJournal.DisplayAll();                          //Display all entries in the journal
                    break;

                case "3":
                    Console.Write("Enter filename to save the journal: ");
                    string saveFile = Console.ReadLine();             //Get filename from the user
                    theJournal.SaveToFile(saveFile);                  //save the journal to the file.
                    break;

                case "4":
                    Console.Write("Enter filename to load the journal from: ");
                    string loadFile = Console.ReadLine();             //Get the filename to load from
                    theJournal.LoadFromFile(loadFile);                //Load journal from file
                    break;

                case "5":
                    Console.WriteLine("Goodbye!"); 
                    return;                                           //Exit the program

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;

            }
            

        }

    }
}