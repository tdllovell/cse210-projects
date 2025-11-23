class EternalGoal : Goal
{
    public EternalGoal()
    {
        _type = "eternal";
    }
    public EternalGoal(string name, string desc, int points)
    {
        _name = name;
        _description = desc;
        _points = points;
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"() {_name}: {_description} - {_points}");
    }
    public override string GetFileOutput()
    {
        return $"{_type}`{_name}`{_description}`{_points}";
    }
}