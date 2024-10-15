
class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide the word
    public void Hide()
    {
        _isHidden = true;
    }
    

    // Show the word
    public void Show()
    {
        _isHidden = false;
    }


    // This is for checking if the word is hidden.
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Get the display text of the word(word itself or underscores)
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length): _text;
    }

}    
