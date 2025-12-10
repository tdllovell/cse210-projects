class Running : Exercise
{
    private float _distance;
    public Running(string date, int length, float distance) : base(date, length)
    {
        _type = "Running";
        _distance = distance;
    }

    public override float CalculateDistance()
    {
        return _distance;
    }
    public override float CalculatePace()
    {
        return _length / _distance;
    }
    public override float CalculateSpeed()
    {
        return _distance / _length * 60;
    }
}