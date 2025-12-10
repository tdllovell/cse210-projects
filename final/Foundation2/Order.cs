class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(string customer, string address, string city, string state, string country = "USA")
    {
        _customer = new Customer(customer, address, city, state, country);
    }

    public void AddProduct(string name, string ID, decimal price, int amount)
    {
        Product product = new Product(name, ID, price, amount);
        _products.Add(product);
    }

    public decimal TotalPrice()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotal();
        }
        if (_customer.IsUS())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine();
        Console.WriteLine("Packing Label");
        foreach (Product product in _products)
        {
            Console.WriteLine(product.ToPackingLabel());
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine();
        Console.WriteLine("Shipping Label");
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress());
    }
}