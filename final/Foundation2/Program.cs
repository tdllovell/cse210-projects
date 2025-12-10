using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        Order order1 = new Order("Kevin McCallister", "671 Lincoln Boulevard", "Winnetka", "Illinois");
        order1.AddProduct("Bread", "GR8223", 2.52m, 1);
        order1.AddProduct("Milk", "DA1423", 2.27m, 1);
        order1.AddProduct("Mac n Cheese", "KR8002", 4.70m, 2);
        order1.AddProduct("Laundry Detergent", "HO2222", 5.64m, 1);
        orders.Add(order1);

        //I used Microsoft Copilot to come up with product and person info. The code is still my own though.
        Order order2 = new Order("Johnathan Reed","742 Maple Avenue","Springfield","Illinois");
        order2.AddProduct("Bananas", "FO1234", 0.59m, 6);
        order2.AddProduct("Dish Soap", "HO5678", 2.49m, 2);
        order2.AddProduct("Chocolate Bar", "FO2468", 1.49m, 15);
        order2.AddProduct("Light Bulbs (4-pack)", "HO1357", 6.49m, 3);
        orders.Add(order2);

        Order order3 = new Order("Amelia Clarke","19 Oakwood Lane","Brighton","East Sussex","United Kingdom");
        order3.AddProduct("Brown Eggs (Dozen)", "FO1111", 2.99m, 5);
        order3.AddProduct("Laundry Detergent", "HO2222", 5.64m, 2);
        order3.AddProduct("Bottled Water (24-pack)", "FO3333", 15.99m, 3);
        order3.AddProduct("Cheddar Cheese Block", "FO4444", 4.79m, 1);
        orders.Add(order3);

        foreach (Order order in orders)
        {
            order.DisplayPackingLabel();
            order.DisplayShippingLabel();
            Console.WriteLine();
            Console.WriteLine($"Total: {order.TotalPrice()}");
            Console.WriteLine();
        }
    }
}