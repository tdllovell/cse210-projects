abstract class Exercise
{
    protected string _type;
    protected string _date;
    protected int _length;

    public Exercise(string date, int length)
    {
        _date = date;
        _length = length;
    }

    abstract public float CalculateDistance();
    abstract public float CalculateSpeed();
    abstract public float CalculatePace();
    public void DisplaySummary()
    {
        Console.WriteLine($"{_date} {_type} ({_length} minutes) - Distance {CalculateDistance()}, Speed {CalculateSpeed()} mph, Pace {CalculatePace()} min per mile");
    }
}