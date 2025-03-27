class Comment
/*
its responsability is to track the
person who made the comment and the comment text itself(its content)
*/
{
    //class atributes
    private string _name;
    private string _text;


    //Getter and Setter:
    public string Name { get { return _name; } set { _name = value; } }
    public string Text { get { return _text; } set { _text = value; } }

    //constructor:
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }
}