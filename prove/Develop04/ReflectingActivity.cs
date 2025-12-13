namespace Develop04;

public class ReflectingActivity : Activity
{
    private List<string> _promptList = new List<string>();
    private List<string> _reflectionQuestions = new List<string>();

    public ReflectingActivity()
    {
        _type = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _promptList.Add("Think of a time when you stood up for someone else.");
        _promptList.Add("Think of a time when you did something really difficult.");
        _promptList.Add("Think of a time when you helped someone in need.");
        _promptList.Add("Think of a time when you did something truly selfless.");

        _reflectionQuestions.Add("Why was this experience meaningful to you?");
        _reflectionQuestions.Add("Had you ever done anything like this before?");
        _reflectionQuestions.Add("How did you get started?");
        _reflectionQuestions.Add("How did you feel when it was complete?");
        _reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
        _reflectionQuestions.Add("What is your favorite thing about this experience?");
        _reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
        _reflectionQuestions.Add("What did you learn about yourself through this experience?");
        _reflectionQuestions.Add("How can you keep this experience in mind in the future?");
    }

    public void FirstPrompt()
    {
        Console.WriteLine(SelectPrompt(_promptList));
        if (_duration % 10 >= 8)
        {
            ShowPause(_duration % 10);
        }
        else
        {
            ShowPause(10 + (_duration % 10));
        }
    }
    public override void DisplayActivity()
    {
        DisplayStartMessage();
        FirstPrompt();
        while (_currentTime < _endTime)
        {
            Console.Write(SelectPrompt(_reflectionQuestions));
            ShowPause(10);
        }
        Console.WriteLine();
        DisplayEndMessage();
    }
}
