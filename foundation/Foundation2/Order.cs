
using System.Security.Cryptography.X509Certificates;

public class Order 
{
    private List<Product> products;
    private Customer customer;


    // Constructer
    public Order(Customer aCustomer)
    {
        products = new List<Product>();
        customer = aCustomer;
    }


    // method to add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }


    // Method that calculate the total cost of the order including shipping.
    public double GetTotalPrice()
    {
        double totalPrice = 0;


        // all product added together
        foreach (Product product in products)
        {
            totalPrice += product.GetTotalPrice();
        }

        // Add shipping cost based on the customer's location
        double shippingCost = customer.IsInUSA() ? 5.0 : 35.0;
        totalPrice += shippingCost;
        return totalPrice;

    }


    // Method to generate the packing label
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label: \n";
        foreach (Product product in products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n;";
        }
        return packingLabel;
    }
    // Method to generate the shiping label(customer name and addrss)
    public string GetShippingLabel()
    {
        string GetShippingLabel = $"Shipping Label:\n{customer.GetName()}\n {customer.GetAddress()}";
        return GetShippingLabel;
    }


}

