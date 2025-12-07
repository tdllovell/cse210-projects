class Product
{
    private string _name;
    private string _ID;
    private decimal _unitPrice;
    private int _quantity;

    public Product(string name, string ID, decimal price, int amount)
    {
        _name = name;
        _ID = ID;
        _unitPrice = price;
        _quantity = amount;
    }

    public decimal GetTotal()
    {
        return _unitPrice * _quantity;
    }

    public string ToPackingLabel()
    {
        return $"{_ID} {_name} - {_quantity}";
    }
}