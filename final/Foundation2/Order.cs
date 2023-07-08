public class Order
{
    private List<Product> productList;
    private Customer customer;
    private decimal shippingCost;

    public Order(List<Product> productList, Customer customer)
    {
        this.productList = productList;
        this.customer = customer;

        if (customer.IsInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
    }
    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;

        foreach (Product product in productList)
        {
            totalCost += product.Price;
        }

        return totalCost + shippingCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in productList)
        {
            packingLabel += $"Name: {product.Name}, ID: {product.ProductId}\n";
        }

        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"Name: {customer.Name}\nAddress:\n{customer.GetFullAddress()}";
    }
}
























// public class Order
// {
//     private List<Product> _products;
//     private Customer _customer;

//     public Order(List<Product> products, Customer customer)
//     {
//         this._products = products;
//         this._customer = customer;
//     }

//     public double CalculateTotalCost()
//     {
//         double totalPrice = 0;
//         foreach (Product _product in _products)
//         {
//             totalPrice = _product.Price * _product.Quantity;
//         }

//         if (_customer.IsInUSA())
//         {
//             totalPrice += 5; // USA shipping coast
//         }
//         else
//         {
//             totalPrice += 30; // international shipping coast
//         }

//         return totalPrice;
//     }

//     public string GetPackingLabel()
//         {
//             string packingLabel = "";
//             foreach (Product product in _products)
//             {
//                 packingLabel += $"Product Name: {product.ProductName}, ID: {product.ProductID}\n";
                
//             }
//             return packingLabel;
//         }

//     public string GetShippingLabel()
//         {
//             return $"Customer name: {_customer.CustomerName}\n {_customer.GetAddressString()}";
            
//         }
    

// }
