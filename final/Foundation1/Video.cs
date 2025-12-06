class Video
{
    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _videoLength = length;
    }

    public void AddComment(string user, string content)
    {
        Comment comment = new Comment(user, content);
        _comments.Add(comment);
    }

    public int CountComments()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"\"{_title}\" ({_videoLength} seconds) by {_author}");
        Console.WriteLine($"Comments: {CountComments()}");
        foreach (Comment comment in _comments)
        {
            comment.DisplayContent();
        }
    }
}