
class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constractor for a single verse
    public Reference(string book, int chapter, int verse)  
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;  // Single verse
    }  


    // Constractor for the a verse range
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }


    // Get the display text for the reference
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter} {_verse}-{_endVerse}";
        }
    }
}