namespace Develop04;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _type = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void ShowPause(int secs)
    {
        Console.Write(" ");
        for (int i = secs; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.Write(" ");
        Console.WriteLine();
    }
    public void FirstCycle()
    {
        int overflow = GetDuration() % 5;
        if (overflow <= 2)
        {
            Console.Write("Breathe in...");
            ShowPause(5);
            Console.Write("Breathe out...");
            ShowPause(5 + overflow);
        }
        else
        {
            Console.Write("Breathe in...");
            ShowPause(overflow);
            Console.Write("Breathe out...");
            ShowPause(5);
        }
    }

    public override void DisplayActivity()
    {
        DisplayStartMessage();
        FirstCycle();
        while (_currentTime < _endTime)
        {
            Console.Write("Breathe in...");
            ShowPause(5);
            _currentTime = DateTime.Now;
            if (_currentTime < _endTime)
            {
                Console.Write("Breathe out...");
                ShowPause(5);
                _currentTime = DateTime.Now;
            }
        }
        Console.WriteLine();
        DisplayEndMessage();
    }
}
