class Circle : Shape
{
    private int _radius;

    public Circle() { }
    public Circle(string color, int radius)
    {
        _radius = radius;
        SetColor(color);
    }

    public int GetRadius() { return _radius; }
    public void SetRadius(int radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * 3.14;
    }
}