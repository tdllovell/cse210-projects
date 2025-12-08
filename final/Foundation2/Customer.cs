class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string address, string city, string state, string country = "USA")
    {
        _name = name;
        _address = new Address(address, city, state, country);
    }

    public string GetAddress() { return _address.ReturnAddress(); }
    public string GetName() { return _name; }
    public bool IsUS() { return _address.IsUS(); }
}