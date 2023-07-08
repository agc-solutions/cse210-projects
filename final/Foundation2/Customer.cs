using System;
using System.Collections.Generic;

public class Customer
{
    private string name;
    private Address address;
    //private Address oi = new Address();

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
    public string Name
    {
        get { return name; }
    }
    public string GetFullAddress()
    {
        return address.GetFullAddress();
    }
}























// public class Customer
// {
//     // The class have two attributes.
//     // The attributes are private.
//     private string _customerName;
//     private Address _address;

//     // Constructors

//     public Customer()
//     {
//         _customerName = "";
//         //_address = address;
//     }

//     public Customer(string customerName, Address address)
//     {
//         _customerName = customerName;
//         _address = address;
//     }

//     public string CustomerName
//     {
//         get {return _customerName;}
//     }

//     public bool IsInUSA()
//     {
//         return _address.IsInUSA();
//     }

//     public string GetAddressString()
//     {
//         return _address.ToString();
//     }
// }


