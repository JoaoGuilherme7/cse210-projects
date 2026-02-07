public class Video
{
    public string Title;
    public string Author;
    public int Length;
    public List<Comment> Comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        Length = lengthInSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int QuantityOfComments()
    {
        return Comments.Count;
    }
}
