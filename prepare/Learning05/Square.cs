class Square : Shape
{
    private int _side;

    public Square() { }
    public Square(string color, int side)
    {
        _side = side;
        SetColor(color);
    }

    public int GetSide() { return _side; }
    public void SetSide(int side)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}