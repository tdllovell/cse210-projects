class Rectangle : Shape
{
    private int _length;
    private int _width;

    public Rectangle() { }
    public Rectangle(string color, int length, int width)
    {
        _length = length;
        _width = width;
        SetColor(color);
    }

    public int GetLength() { return _length; }
    public void SetLength(int length)
    {
        _length = length;
    }
    public int GetWidth() { return _width; }
    public void SetWidth(int width)
    {
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}