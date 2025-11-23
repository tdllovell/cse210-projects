class SimpleGoal : Goal
{
    private bool _done = false;

    public SimpleGoal()
    {
        _type = "simple";
    }
    public SimpleGoal(string name, string desc, int points, bool done)
    {
        _name = name;
        _description = desc;
        _points = points;
        _done = done;
    }
    public override int RecordProgress()
    {
        if (_done == false)
        {
            _done = true;
            return _points;
        }
        else
        {
            return 0;
        }
    }
    public override void DisplayGoal()
    {
        if (_done)
        {
            Console.WriteLine($"[X] {_name}: {_description} - {_points}");
        }
        else
        {
            Console.WriteLine($"[ ] {_name}: {_description} - {_points}");
        }
    }
    public override string GetFileOutput()
    {
        return $"{_type}`{_name}`{_description}`{_points}`{_done}";
    }
}