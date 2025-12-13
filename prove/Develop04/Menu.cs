namespace Develop04;

public class Menu
{
    private int _selectedActivity;
    public Menu() { }
    public int GetSelection(){ return _selectedActivity; }
    public void SelectActivity()
    {
        Console.Write(
            "1. Breathing Activity\n" +
            "2. Listing Activity\n" +
            "3. Reflecting Activity\n" +
            "4. Quit\n" +
            "Which activity would you like to do? ");
        _selectedActivity = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (_selectedActivity == 1)
        {
            BreathingActivity breathing = new BreathingActivity();
            breathing.DisplayActivity();
        }
        else if (_selectedActivity == 2)
        {
            ListingActivity listing = new ListingActivity();
            listing.DisplayActivity();
        }
        else if (_selectedActivity == 3)
        {
            ReflectingActivity reflecting = new ReflectingActivity();
            reflecting.DisplayActivity();
        }
        else if (_selectedActivity == 4) { }
        else
        {
            Console.WriteLine("Unknown option. Please try again.");
        }
    }
}
