abstract class Shape
{
    private string _color;

    public string GetColor() { return "The color is " + _color; }
    public void SetColor(string color)
    {
        _color = color;
    }

    abstract public double GetArea();
}