public class Address
{
    //Private members variables
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;

    // Constructor

    public Address(string street, string city, string state, string zipCode)
    {
        this._street = street;
        this._city = city;
        this._state = state;
        this._zipCode = zipCode;
    }

    //Method to get the address string
    public string GetAddress()
    {
        return $"{_street}, {_city}, {_state} - {_zipCode}";
    }
}