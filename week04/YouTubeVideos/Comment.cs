/* list of 3-4 comments for each video including the name of the commentor and the comment
*/
public class Comment
{
    private string _userName;
    private string _comment;



    public Comment(string userName, string comment)
    {
        _userName = userName;
        _comment = comment;
    }

    public void GetComment()
    {
        Console.WriteLine($"    User: {_userName} Comment: {_comment}");
    }
}