class Biking : Exercise
{
    private float _speed;
    public Biking(string date, int length, float speed) : base(date, length)
    {
        _type = "Biking";
        _speed = speed;
    }

    public override float CalculateDistance()
    {
        return _speed * _length / 60;
    }
    public override float CalculatePace()
    {
        return 60 / _speed;
    }
    public override float CalculateSpeed()
    {
        return _speed;
    }
}