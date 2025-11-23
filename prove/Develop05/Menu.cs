using System.IO;
class Menu
{
    private int _menuInput;
    private int _input;
    private List<Goal> _goals = new List<Goal>();
    private int _points = 0;
    private string _fileName;
    public Menu() { }
    public int GetMenuInput(){ return _menuInput; }
    public void DisplayOptions()
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Create goal");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Record progress");
        Console.WriteLine("4. Save goals to file");
        Console.WriteLine("5. Load goals from file");
        Console.WriteLine("6. Quit");
        Console.Write("Select an option: ");
    }
    public void SelectOption()
    {
        DisplayOptions();
        _menuInput = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (_menuInput == 1)
        {
            CreateGoal();
        }
        else if (_menuInput == 2)
        {
            ListGoals();
        }
        else if (_menuInput == 3)
        {
            ListGoals();
            Console.WriteLine("Which goal would you like to record progress for? ");
            _input = int.Parse(Console.ReadLine());
            int _pointIncrease = _goals[_input - 1].RecordProgress();
            _points += _pointIncrease;
            Console.WriteLine($"You just earned {_pointIncrease} points, which means you now have {_points} points!");
        }
        else if (_menuInput == 4)
        {
            Console.WriteLine("What name would you like to give the file? ");
            _fileName = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
                Console.WriteLine(_points);
                foreach (Goal goal in _goals)
                {
                    Console.WriteLine(goal.GetFileOutput());
                }
            }
        }
        else if (_menuInput == 5)
        {
            Console.WriteLine("What is the name of the file? ");
            _fileName = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(_fileName);
            _points = int.Parse(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("`");
                if (parts[0] == "simple")
                {
                    Goal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                    _goals.Add(goal);
                }
                else if (parts[0] == "checklist")
                {
                    Goal goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                    _goals.Add(goal);
                }
                else if (parts[0] == "eternal")
                {
                    Goal goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                    _goals.Add(goal);
                }
            }
        }
        else if (_menuInput == 6)
        {

        }
        else
        {
            Console.WriteLine("Selection unknown. Please read your options and try again.");
            Console.WriteLine();
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
        Console.Write("Select an option: ");
        _input = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (_input == 1)
        {
            Goal goal = new SimpleGoal();
            goal.CreateGoal();
            _goals.Add(goal);
        }
        else if (_input == 2)
        {
            Goal goal = new EternalGoal();
            goal.CreateGoal();
            _goals.Add(goal);
        }
        else if (_input == 3)
        {
            Goal goal = new ChecklistGoal();
            goal.CreateGoal();
            _goals.Add(goal);
        }
    }
    public void ListGoals()
    {
        int i = 1;
        Console.WriteLine("These are your goals: ");
        foreach (Goal goal in _goals)
        {
            Console.Write(i + ". ");
            goal.DisplayGoal();
            i++;
        }
        Console.WriteLine();
    }
}