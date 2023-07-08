public class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;
    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }
    public decimal Price
    {
        get { return price * quantity; }
    }
    public string Name
    {
        get { return name; }
    }
    public string ProductId
    {
        get { return productId; }
    }
}

























// public class Product
// {
//     private string _productName;
//     private int _productID;
//     private double _price;
//     private int _quantity;

//     public string ProductName
//     {
//         get {return _productName;}
//     }

//     public int ProductID
//     {
//         get {return _productID;}
//     }

//     public double Price
//     {
//         get {return _price;}
//     }

//     public int Quantity
//     {
//         get {return _quantity;}
//     }

//     public Product(string productName, int productID, double price, int quantity)
//     {
//         _productName = productName;
//         _productID = productID;
//         _price = price;
//         _quantity = quantity;
//     }
// }



