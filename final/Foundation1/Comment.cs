public class Comment
{
    private string _commenter = "";
    private string _comment = "";

    public string GetCommenter()
    {
        return _commenter;
    }
    public void SetCommenter(string commenter)
    {
        _commenter = commenter;
    }
    public string GetComment()
    {
        return _comment;
    }
    public void SetComment(string comment)
    {
        _comment = comment;
    }
    public void CommentDisplay()
    {
        Console.WriteLine($"Comment: '{_comment}' - Author {_commenter}.");
    }

}