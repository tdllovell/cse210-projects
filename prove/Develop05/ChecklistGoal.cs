class ChecklistGoal : Goal
{
    private int _done = 0;
    private int _toDo;
    private int _bonusPoints;

    public ChecklistGoal()
    {
        _type = "checklist";
    }
    public ChecklistGoal(string name, string desc, int points, int done, int toDo, int bonus)
    {
        _name = name;
        _description = desc;
        _points = points;
        _done = done;
        _toDo = toDo;
        _bonusPoints = bonus;
    }
    public override void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("Write a short description of your goal: ");
        _description = Console.ReadLine();
        Console.Write("How many points is your goal worth? ");
        _points = int.Parse(Console.ReadLine());
        Console.Write("How many times would you like to do this goal? ");
        _toDo = int.Parse(Console.ReadLine());
        Console.Write($"How many bonus points would you like to receive after completing the goal {_toDo} times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
    public override int RecordProgress()
    {
        if (_done < _toDo)
        {
            _done += 1;
            return _points;
        }
        else if (_done == _toDo)
        {
            return _points + _bonusPoints;
        }
        else
        {
            return 0;
        }
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[{_done}/{_toDo}] {_name}: {_description} - {_points}, Bonus: {_bonusPoints}");
    }
    public override string GetFileOutput()
    {
        return $"{_type}`{_name}`{_description}`{_points}`{_done}`{_toDo}`{_bonusPoints}";
    }
}