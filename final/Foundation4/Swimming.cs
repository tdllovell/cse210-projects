class Swimming : Exercise
{
    private int _lapCount;

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _type = "Swimming";
        _lapCount = laps;
    }

    public override float CalculateDistance()
    {
        return _lapCount * 0.031f;
    }
    public override float CalculatePace()
    {
        return _length / CalculateDistance();
    }
    public override float CalculateSpeed()
    {
        return CalculateDistance() / _length * 60;
    }
}