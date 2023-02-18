using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address();
        address1.SetCity("Paris");
        address1.SetStreet("24 Rue du Commandant Guilbaud");
        address1.SetCountry("France");
        address1.SetState("Paris");
        address1.SetInternational(true);

        Customer customer1 = new Customer();
        customer1.SetName("Kylian Mbappe");
        customer1.SetAddress(address1);

        Product product1C1 = new Product();
        product1C1.SetName("Nike Mercurial Vapor 9");
        product1C1.SetId("NKVM9");
        product1C1.SetPrice(300);
        product1C1.SetQuantity(2);

        Product product2C1 = new Product();
        product2C1.SetName("Stanley Bottle");
        product2C1.SetId("SLY22");
        product1C1.SetPrice(50);
        product2C1.SetQuantity(10);

        Product product3C1 = new Product();
        product3C1.SetName("Google Pixel 7 Pro");
        product3C1.SetId("IP2006");
        product3C1.SetPrice(700);
        product3C1.SetQuantity(3);

        Order order1 = new Order();
        order1.SetCustomer(customer1);
        order1.SetProduct(product1C1);
        order1.SetProduct(product2C1);
        order1.SetProduct(product3C1);

        //2
        Address address2 = new Address();
        address2.SetCity("San Juan");
        address2.SetStreet("500 Av. Arterial B");
        address2.SetCountry("Puerto Rico");
        address2.SetState("San Juan");
        address2.SetInternational(true);
        address2.Display();

        Customer customer2 = new Customer();
        customer2.SetName("Myke Towers");
        customer2.SetAddress(address2);

        Product product1C2 = new Product();
        product1C2.SetName("Asus Gaming montior");
        product1C2.SetId("SUS252");
        product1C2.SetPrice(600);
        product1C2.SetQuantity(1);
        Console.WriteLine(product1C2.CalculatePrice());

        Product product2C2 = new Product();
        product2C2.SetName("Logitech g29");
        product2C2.SetId("LG29");
        product2C2.SetPrice(350);
        product2C2.SetQuantity(3);
        Console.WriteLine(product2C2.CalculatePrice());

        Order order2 = new Order();
        order2.SetCustomer(customer2);
        order2.SetProduct(product1C2);
        order2.SetProduct(product2C2);

        List<Order> ordenes = new List<Order>();
        ordenes.Add(order1);
        ordenes.Add(order2);

        foreach(Order orden in ordenes)
        {
            orden.GetShippingLabel();
            Console.WriteLine("");
            orden.ShowPackingLabel();
            Console.WriteLine("");
            Console.WriteLine(orden.GetTotalPrice());
            Console.WriteLine("");                
        }
    }
}