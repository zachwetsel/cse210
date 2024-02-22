using System;

class Program
{
    static void Main(string[] args)
    {
        Address customerAddress = new Address("1291 Main St", "Provo", "UT", "USA");
        Customer customer = new Customer("John Doe", customerAddress);
        Order order1 = new Order(customer);

        order1.AddProduct(new Product("Product 1", "001", 10.99, 2));
        order1.AddProduct(new Product("Product 2", "002", 15.49, 1));

        Console.WriteLine("Order 1 Details:");
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Address secondAddress = new Address("4593 Center St", "Canadian City", "Vancouver", "Canada");
        Customer secondCustomer = new Customer("Captain Canada", secondAddress);
        Order order2 = new Order(secondCustomer);

        order2.AddProduct(new Product("Product 3", "003", 20.99, 3));

        Console.WriteLine("Order 2 Details:");
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}