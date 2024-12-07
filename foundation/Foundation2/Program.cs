using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", 101, 500.00, 2);
        Product product2 = new Product("Mouse", 102, 25.00, 1);
        Product product3 = new Product("Keyboard", 103, 45.00, 1);

        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Vancouver", "BC", "Canada");

        Customer customer1 = new Customer("Alice", address1);
        Customer customer2 = new Customer("Bob", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        DisplayOrderInfo(order1);
        DisplayOrderInfo(order2);
    }

    static void DisplayOrderInfo(Order order)
    {
        Console.WriteLine("Order Details:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
        Console.WriteLine();
    }
}