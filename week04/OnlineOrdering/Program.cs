using System;   
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St","Anytown","CA","USA");
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");

        Customer customer1 = new Customer("Tobey Maguire", address1);
        Customer customer2 = new Customer("Neymar Jr.", address2);
    

        Product laptop     = new Product("Laptop", "P001", 999.99m, 1);
        Product smartphone = new Product("Smartphone", "P002", 499.99m, 2);
        Product pen        = new Product("Pen", "P003", 1.99m, 10);
        Product backpack   = new Product("Backpack", "P004", 49.99m, 1);

        Order order1 = new Order(customer1, new List<Product> { laptop, pen });
        Order order2 = new Order(customer2, new List<Product> { smartphone, backpack });

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.CalculateTotalPrice():0.00}");
            Console.WriteLine();
        }
    }
}
