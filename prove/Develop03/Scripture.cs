
using System;
using System.Collections.Generic;
using System.Linq;
    
class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w=> new Word(w)).ToList();
    }

    // Hide a few random words inthe scripture.
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        var visibleWords  =  _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }  
    // Get the display text of the scripture, including the hidden words
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = string.Join(" ", _words.Select(w=> w.GetDisplayText()));
        return $"{referenceText} \n {wordsText}";

    }

    // Check if all words in the scripture are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(w=> w.IsHidden());
    }
    
}
