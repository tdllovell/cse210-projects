class Comment
{
    private string _author;
    private string _content;

    public Comment(string author, string content)
    {
        _author = author;
        _content = content;
    }

    public void DisplayContent()
    {
        Console.WriteLine($" -->\"{_content}\" -- {_author}");
    }
}