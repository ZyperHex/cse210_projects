class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //This class needs 2 constructors, one for scriptures with one single verse...
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    
    //And other constructor for 2 or more verses.
    public Reference(string book, int chapter, int startVerse, int endVerse) 
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }


    public string GetDisplayText()
    {
        string text = $"{_book} {_chapter}: {_verse}";
        return text;
    }
}
