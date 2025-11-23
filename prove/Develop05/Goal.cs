abstract class Goal
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;

    virtual public void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("Write a short description of your goal: ");
        _description = Console.ReadLine();
        Console.Write("How many points is your goal worth? ");
        _points = int.Parse(Console.ReadLine());
    }
    virtual public int RecordProgress()
    {
        return _points;
    }
    abstract public void DisplayGoal();
    abstract public string GetFileOutput();
}