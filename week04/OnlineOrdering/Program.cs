using System;

class Program
{
    static void Main(string[] args)
    {
        Product girlBat = new Product("Girls Bat", "001", 250.49);
        Product boyBat = new Product("Boys Bat", "002", 255.49);
        Product girlGlove = new Product("Girls Glove", "003", 66.95);
        Product boyGlove = new Product("Boys Glove", "004", 69.95);
        Product ball = new Product("Ball", "005", 4.99);
        Product girlHelmet = new Product("Girls Helmet", "006", 75.99);
        Product boyHelmet = new Product("Boys Helmet", "007", 77.99);


        Order order001 = new Order();
        order001.SetCustomer("Tom Cruise");
        order001.SetCustomerAddress("123 Main st", "Salt Lake City", "UT", "84111", "US");
        order001.AddProduct(boyGlove, 2);
        order001.AddProduct(boyHelmet, 3);
        Console.Clear();
        order001.GetShippingLabel();
        Console.WriteLine();
        order001.GetPackingLabel();
        Console.WriteLine();

        Order order002 = new Order();
        order002.SetCustomer("Homer Simpson");
        order002.SetCustomerAddress("742 Evergreen Terrace", "Springfield", "Ohio", "43083", "US");
        order002.AddProduct(boyGlove, 1);
        order002.AddProduct(girlGlove, 1);
        order002.AddProduct(boyHelmet, 1);
        order002.AddProduct(girlHelmet, 1);
        order002.GetShippingLabel();
        Console.WriteLine();
        order002.GetPackingLabel();

        Order order003 = new Order();
        order003.SetCustomer("Sherlock Holmes");
        order003.SetCustomerAddress("221b Baker st", "London", "England", "NW1 6XE", "United Kingdom");
        order003.AddProduct(ball, 200);
        order003.AddProduct(boyBat, 2);
        order003.AddProduct(girlBat, 2);
        Console.WriteLine();
        order003.GetShippingLabel();
        Console.WriteLine();
        order003.GetPackingLabel();

    }
}