class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country = "USA";

    public Address(string address, string city, string state)
    {
        _streetAddress = address;
        _city = city;
        _state = state;
    }
    public Address(string address, string city, string state, string country)
    {
        _streetAddress = address;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsUS()
    {
        if (_country == "USA")
        { return true; }
        else { return false; }
    }
    public string ReturnAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}, {_country}";
    }
}