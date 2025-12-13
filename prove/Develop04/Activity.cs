namespace Develop04;

abstract public class Activity
{
    protected string _type;
    protected string _description;
    protected int _duration;
    protected DateTime _startTime;
    protected DateTime _endTime;
    protected DateTime _currentTime;
    protected Random randomizer = new Random();

    public Activity() { }

    public int GetDuration() { return _duration; }
    virtual public void ShowPause(int secs)
    {
        Console.Write(" ");
        if (secs % 2 == 1)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b");
            secs -= 1;
        }
        for (int i = 0; i < secs; i += 2)
        {
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b");
        }
        Console.Write(" ");
        Console.WriteLine();
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"You have chosen the {_type} activity. {_description}");
        Console.Write("For how many seconds would you like to do this activity? ");
        _duration = int.Parse(Console.ReadLine());
        _startTime = DateTime.Now.AddSeconds(5);
        _endTime = _startTime.AddSeconds(_duration);

        Console.Write("Prepare to begin.");
        ShowPause(5);
        Console.WriteLine();
    }

    public void DisplayEndMessage()
    {
        Console.Write("Great job!");
        ShowPause(3);
        Console.Write($"You have now done the {_type} activity for {_duration} seconds.");
        ShowPause(5);
    }
    abstract public void DisplayActivity();
    public string SelectPrompt(List<string> prompts)
    {
        int number = randomizer.Next(prompts.Count);
        return prompts[number];
    }
}
