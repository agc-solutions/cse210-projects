using System;
public class Program
{
    public static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "City1", "State1", "USA");
        Customer customer1 = new Customer("Customer1", address1);
        Product product1 = new Product("Product1", "P1", 10, 2);
        Product product2 = new Product("Product2", "P2", 15, 3);

        List<Product> productList1 = new List<Product>();
        productList1.Add(product1);
        productList1.Add(product2);

        Order order1 = new Order(productList1, customer1);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine();

        Address address2 = new Address("456 Broadway", "City2", "State2", "Canada");
        Customer customer2 = new Customer("Customer2", address2);
        Product product3 = new Product("Product3", "P3", 10, 2);
        Product product4 = new Product("Product4", "P4", 15, 3);
        //Product product5 = new Product("Product5", "P5", 30, 2);

        List<Product> productList2 = new List<Product>();
        productList2.Add(product3);
        productList2.Add(product4);
        //productList2.Add(product5);

        Order order2 = new Order(productList2, customer2);

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: US$ " + order2.CalculateTotalCost());

        Console.WriteLine();

    }
}



















// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create products
//         Product product1 = new Product("Product 1", 1, 10, 2);
//         Product product2 = new Product("Product 2", 1, 10, 2);


//         // Create Address
//         Address addressUSA = new Address("865 Water St", "Nauvoo", "IL", "USA");
//         Address addressInternational = new Address("Av. Guilhermina, 648 ap 85", "Praia Grande", "SP", "Brazil");


//         // Create customers
//         Customer customerUSA = new Customer("Joseph Smith Jr.", addressUSA);
//         Customer customerInternational = new Customer("Adamastor G. Cavalcante", addressInternational);

//         // Create orders
//         List<Product> productsOrder1 = new List<Product> {product1, product2};
//         Order order1 = new Order(productsOrder1, customerUSA);
//         List<Product> productsOrder2 = new List<Product> {product2};
//         Order order2 = new Order(productsOrder2, customerInternational);


//         // Get and display order information
//         Console.WriteLine("\nOrder 1:");
//         Console.WriteLine("Packing Label:");
//         Console.WriteLine(order1.GetPackingLabel());
//         Console.WriteLine("Shipping Label:");
//         Console.WriteLine(order1.GetShippingLabel());
//         Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());

//         Console.WriteLine();

//         Console.WriteLine("Order 2:");
//         Console.WriteLine("Packing Label:");
//         Console.WriteLine(order2.GetPackingLabel());
//         Console.WriteLine("Shipping Label:");
//         Console.WriteLine(order2.GetShippingLabel());
//         Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
//     }
// }



