using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("129 Old Main Road", "Los Angels", "CA", "USA");
        Customer customer1 = new Customer("Edward Smith", address1);
        

        // Create product for the first order
        Product product1 = new Product("Laptop", "T540", 1530.0, 1);
        Product product2 = new Product("Headphones", "L232L", 30.0, 3);


        // Addition of orders in the first product
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);


        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());


        // display total cost of the first order
        Console.WriteLine($"Total Cost: {order1.GetTotalPrice()}\n");
        
        //  create address and customer for the second order
        Address address2 = new Address("54 Alfred Road", "Pinetown", "KwaZulu Nala", "South Africa");
        Customer customer2 = new Customer("Sifiso", address2);

        Product product3 = new Product("Tablet", "Q5521", 600.0, 1); 
        Product product4 = new Product("Microphone", "QW120", 230.0, 2);
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // display packing and shipping labels for the second order
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());

        // display total cost of the second order
        Console.WriteLine($"Tatal Cost: ${order2.GetTotalPrice()}");

    }
}