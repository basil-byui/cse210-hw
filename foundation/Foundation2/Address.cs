
// class that holds customer address details
public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    // Constructor
    public Address(string aStreet, string aCity, string aState, string aCountry)
    {
        street = aStreet;
        city = aCity;   
        state = aState;
        country = aCountry; 
    }

    // Method to check if it a US address
    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }

    // Method to return the full address
    public string GetFullAddress()
    {
        return $"{street} \n{city}, {state}\n{country}";
    }
}