namespace Develop04;

public class ListingActivity : Activity
{
    private List<string> _listingPrompts = new List<string>();
    private List<string> _listedItems = new List<string>();
    private string _prompt;
    public ListingActivity()
    {
        _type = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _listingPrompts.Add("Who are people that you appreciate?");
        _listingPrompts.Add("What are personal strengths of yours?");
        _listingPrompts.Add("Who are people that you have helped this week?");
        _listingPrompts.Add("When have you felt the Holy Ghost this month?");
        _listingPrompts.Add("Who are some of your personal heroes?");
    }

    public override void DisplayActivity()
    {
        DisplayStartMessage();
        _prompt = SelectPrompt(_listingPrompts);
        Console.Write($"Prepare to type as many responses to the following prompt as you can think of: \n{_prompt}");
        ShowPause(8);
        Console.WriteLine("Begin");
        while (_currentTime < _endTime)
        {
            _listedItems.Add(Console.ReadLine());
            _currentTime = DateTime.Now;
        }
        SaveResponses(_listedItems);
        DisplayEndMessage();
    }
    public void SaveResponses(List<string> responses)
    {
        Console.Write($"Your time has ended. You have listed {_listedItems.Count()} items. Would you like to save your responses? (y/n) ");
        string doSave = Console.ReadLine();
        Console.WriteLine();
        while (doSave.ToLower() != "no" && doSave.ToLower() != "n")
        {
            if ((doSave.ToLower() == "yes") || (doSave.ToLower() == "y"))
            {
                Console.WriteLine("What name would you like to give the file? ");
                string _fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(_fileName))
                {
                    outputFile.WriteLine(_prompt);
                    foreach (string item in _listedItems)
                    {
                        outputFile.WriteLine(item);
                    }
                }
                Console.WriteLine("Your file has been saved.");
                break;
            }
            else if ((doSave.ToLower() == "no") || (doSave.ToLower() == "n")) { }
            else
            {
                Console.WriteLine("Unknown input.");
            }
        }
    }
}
