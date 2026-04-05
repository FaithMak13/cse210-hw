namespace OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - US customer
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Widget A", "W001", 9.99, 3));
        order1.AddProduct(new Product("Gadget B", "G002", 14.99, 2));
        order1.AddProduct(new Product("Thingamajig C", "T003", 4.49, 5));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}\n");

        // Order 2 - International customer
        Address address2 = new Address("45 Queen Street", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Super Gizmo", "S004", 24.99, 1));
        order2.AddProduct(new Product("Mega Doohickey", "M005", 7.50, 4));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}

