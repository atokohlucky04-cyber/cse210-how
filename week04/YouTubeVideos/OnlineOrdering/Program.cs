
using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: USA Customer
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mouse", "MS101", 25.50m, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "KB202", 75.00m, 1));

        // Order 2: International Customer
        Address address2 = new Address("45 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("USB-C Hub", "UC303", 40.00m, 1));
        order2.AddProduct(new Product("Monitor Stand", "MS404", 30.00m, 2));
        order2.AddProduct(new Product("HDMI Cable", "HD505", 10.50m, 3));

        // Display Order 1
        Console.WriteLine("====================");
        Console.WriteLine("ORDER 1 DETAILS");
        Console.WriteLine("====================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalOrderCost():0.00}\n");

        // Display Order 2
        Console.WriteLine("====================");
        Console.WriteLine("ORDER 2 DETAILS");
        Console.WriteLine("====================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalOrderCost():0.00}");
        Console.WriteLine("====================");
    }
}