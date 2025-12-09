class Outdoor : Event
{
    private string _forecast;
    public Outdoor(string title, string desc, string date, string time, string streetAddress, string city, string state, string forecast, string country = "USA") : base(title, desc, date, time, streetAddress, city, state, country)
    {
        _type = "Outdoor";
        _forecast = forecast;
    }

    public override void DisplayFull()
    {
        Console.WriteLine($"{_title}\n{_description}\n{_date} at {_time}\nLocated at {_address.ReturnAddress()}\nWeather forecast: {_forecast}");
    }
}