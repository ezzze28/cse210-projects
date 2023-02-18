public class Video
{
    private string _title = "";
    private string _author = "";
    private int _length;
    public List<Comment> _comments = new List<Comment>();

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }
    public int GetLength()
    {
        return _length;
    }
    public void SetLength(int length)
    {
        _length = length;
    }
    public void SetComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int NumberComments()
    {
        return _comments.Count();
    }
    public void Display()
    {
        
        int totalComments = NumberComments();
        Console.WriteLine($"Youtube Video: '{_title}', by {_author}, with a length of {_length} seconds"); 
        Console.WriteLine($"Total Comments {totalComments}");
        foreach(Comment commentario in _comments)
        {   
            commentario.CommentDisplay();
        }
    }
    public Video()
    {

    }

}