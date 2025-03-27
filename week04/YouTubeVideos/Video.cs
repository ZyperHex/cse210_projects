using System.Net;

class Video
/*
its responsability is to track the title, 
author, and lenght(in seconds) of the video
*/
{
    //class atributes:
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    //getters and setters
    public string Title { get { return _title; } set { _title = value; } }
    public string Author { get { return _author; } set { _author = value; } }
    public int Length { get { return _length; } set { _length = value; } }
    public List<Comment> Comments { get { return _comments; } }


    //constructor:
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>(); //Initialize the list of comments
    }

    //method to add a comment.
    public void AddComment(string name, string text)
    {
        Comment newComment = new Comment(name, text);
        _comments.Add(newComment);
    }

    public int CountComments()
    {
        return _comments.Count;
    }
}