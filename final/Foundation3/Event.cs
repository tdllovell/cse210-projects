class Event
{
    protected string _type = "Other";
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    public Event(string title, string desc, string date, string time, string streetAddress, string city, string state, string country="USA")
    {
        _title = title;
        _description = desc;
        _date = date;
        _time = time;
        _address = new Address(streetAddress, city, state, country);
    }

    public string GetEventType() { return _type; }
    public string GetTitle() { return _title; }
    public string GetDescription() { return _description; }
    public string GetDate() { return _date; }
    public string GetTime() { return _time; }
    public Address GetAddress() { return _address; }
    public void DisplayStandard()
    {
        Console.WriteLine($"{_title} - {_description}\n{_date} at {_time}\n{_address.ReturnAddress()}");
    }
    virtual public void DisplayFull()
    {
        Console.WriteLine($"{_title}\n{_description}\n{_date} at {_time}\n{_address.ReturnAddress()}");
    }
    public void DisplayShort()
    {
        Console.WriteLine($"{_type} - {_title} on {_date}");
    }
}