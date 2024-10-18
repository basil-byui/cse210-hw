
// This class holds customer address and theer details
public class Customer
{
    private string name;
    private Address address;

    // Constructer
    public Customer(string aName, Address aAddress)
    {
        name = aName;
        address = aAddress;
    }


    // getter for name
    public string GetName()
    {
        return name;
    }


    // getter for address
    public Address GetAddress()
    {
        return address;
    }


    // method to check if customer is in US
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }


}