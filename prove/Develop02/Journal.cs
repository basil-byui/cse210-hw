using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    //A list to hold defined prompt
    public List<Entry> _entries = new List<Entry>();

    //Add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }


    //Display all entries in the journal

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the Journal.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }



    //Save journal to file.
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
        
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");

            }
        }
        Console.WriteLine($"Journal saved to {file}.");
    }


     
     //Loads the journal from file.
    public void LoadFromFile(string file)
    {
        _entries.Clear();                             //clears the current entries before loading new ones. 

        if (File.Exists(file))
        {
            using(StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|'); //split the line by '|' to extract
                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry(parts[1], parts[2])
                        {
                            _date = parts[0],
                        };
                        _entries.Add(entry);         //add entry to the list

                    }
                }
            }
            Console.WriteLine($"Journal loaded from {file}.");
        }
        else
        {
            Console.WriteLine($"File {file} not found.");
        }
    }

}
   


    





    
    
    
