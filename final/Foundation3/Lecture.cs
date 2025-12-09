class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string desc, string date, string time, string streetAddress, string city, string state, string speaker, int capacity, string country = "USA") : base(title, desc, date, time, streetAddress, city, state, country)
    {
        _type = "Lecture";
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void DisplayFull()
    {
        Console.WriteLine($"{_title}\n{_description}\n{_date} at {_time}\nLocated at {_address.ReturnAddress()}\nSpeaker: {_speaker}\nCapacity: {_capacity}");
    }
}