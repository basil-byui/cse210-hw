using System;
using System.Collections.Generic;
public class PromptGenerator
{
    //A list of predefined prompt.
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "how did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"

    };

    //A random object for generating random prompt
    public Random _random = new Random();
    //reurns the random prompt from the list.
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

}