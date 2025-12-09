class Reception : Event
{
    private string _rsvpEmail;
    public Reception(string title, string desc, string date, string time, string streetAddress, string city, string state, string rsvpEmail, string country = "USA") : base(title, desc, date, time, streetAddress, city, state, country)
    {
        _type = "Reception";
        _rsvpEmail = rsvpEmail;
    }    

    public override void DisplayFull()
    {
        Console.WriteLine($"{_title}\n{_description}\n{_date} at {_time}\nLocated at {_address.ReturnAddress()}\nPlease RSVP to {_rsvpEmail}");
    }
}