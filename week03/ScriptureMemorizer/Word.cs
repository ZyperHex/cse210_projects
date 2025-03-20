class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

public void Hide()
{
    if (!isHidden()) 
    {
        _isHidden = true;
    }
}

    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (isHidden()) // Call isHidden Method
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}