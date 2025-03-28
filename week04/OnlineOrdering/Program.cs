using System;

class Program
{
    static void Main(string[] args)
    {
        //Create an Address
        Address address1 = new Address("752 Main St", "Charlestown", "CA", "USA");

        //Create a Client
        Customer customer1 = new Customer("Joao Felix", address1);

        //Create an Order
        Order order1 = new Order(customer1);

        //Create Products to store in the order of customer1
        Product product1 = new Product("Beans", "022357", 250.0f, 5);
        Product product2 = new Product("Meat", "0005698", 1500.0f, 1);
        Product product3 = new Product("Soda", "AL2503", 300.0f, 2);

        //Now we need to add the products to the order using .Add();
        order1.Products.Add(product1);
        order1.Products.Add(product2);
        order1.Products.Add(product3);


        //Display the information
        DisplayOrderInformation(order1);

        //Do the same to a new order from other customer

        Address address2 = new Address("255 Avellaneda St", "Quilmes", "BsAs", "Argentina");
        Customer customer2 = new Customer("Francisca Villabuena", address2);
        Order order2 = new Order(customer2);

        //Products part
        Product product4 =new Product("Smartphone", "SP004", 6000.0f, 1);
        Product product5 = new Product("Headphones", "LA44562", 2500.0f, 1);

        order2.Products.Add(product4);
        order2.Products.Add(product5);

        //display information
        DisplayOrderInformation(order2);

    static void DisplayOrderInformation(Order order)
    {
        Console.WriteLine("\nOrder Information:");
        Console.WriteLine(order.Customer.GetCustomerInformation());
        Console.WriteLine($"Total Order Price: ${order.TotalPrice()}");
        Console.WriteLine($"Shipping Cost: ${order.ShippingCost()}");
        Console.WriteLine($"Total: ${order.TotalPrice() + order.ShippingCost()}");
        Console.WriteLine("");
        //Console.WriteLine("\nPacking Label:"); this part of the code is unnecessary because the method packing Label integrates this 
        Console.WriteLine(order.PackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.ShippingLabel());
    }
    }
}