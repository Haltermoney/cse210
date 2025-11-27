using System.Security.Cryptography.X509Certificates;

public class Video
{
    private string _title;
    private int _length;
    private string _author;
    private int _numberOfComments;
    private List<Comment> _comments = new List<Comment>();

    public Video()
    {
        _title = "Untitled";
        _length = 0;
        _author = "unknown";
        _comments = new List<Comment>();
    }

    public Video(string title, int length, string author)
    {
        _title = title;
        _length = length;
        _author = author;
        _comments = new List<Comment>();
    }

    public void AddComment(string name, string comment)
    {
        Comment newComment = new Comment(name, comment);
        _comments.Add(newComment);
    }

    public void GetVideo()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Length: {_length}sec, Comments: {NumberOfComments()}");
    }

    public void GetComments()
    {
        foreach (Comment c in _comments)
        {
            c.GetComment();
        }
    }

    public int NumberOfComments()
    {
        _numberOfComments = _comments.Count();
        return _numberOfComments;
    }


}