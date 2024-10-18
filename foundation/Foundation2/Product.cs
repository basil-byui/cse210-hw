
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

// Product class
public class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    // Constructer
    public Product(string aName, string aProductId, double aPrice, int aQuantity)
    {
        name = aName;
        productId = aProductId;
        price = aPrice;
        quantity = aQuantity;
    }

    // getter for name
    public string  GetName()
    {
        return name;
    }

    // getter for productId
    public string GetProductId()
    {
        return productId;
    }

    // Calculate total cost of the product
    public double GetTotalPrice()
    {
        return price * quantity;

    }
}