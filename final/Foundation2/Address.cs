public class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public Address(string streetAddress, string city, string state, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
        this.country = country;
    }
    public bool IsInUSA()
    {
        return country.Equals("USA");
    }
    public string GetFullAddress()
    {
        return $"Street: {streetAddress}\nCity: {city}\nState/Province: {state}\nCountry: {country}";
    }
}


























// public class Address
// {
//     private string _street;
//     private string _city;
//     private string _state;
//     private string _country;

//     public Address(string street, string city, string state, string country)
//     {
//         this._street = street;
//         this._city = city;
//         this._state = state;
//         this._country = country;
//     }
    
//     public bool IsInUSA()
//     {
//         return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);            
//     }
//     public override string ToString()
//     {
//         return $"Street: {_street}\nCity: {_city}\nState/Province: {_state}\nCountry: {_country}";
//     }


// }

