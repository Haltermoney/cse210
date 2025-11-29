public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;
    private double _total;


    public Product(string name, string productID, double price)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = 1;
        _total = _quantity * _price;
    }
    public void UpdateProduct(Product product, int quanitity)
    {
        product._quantity = quanitity;
        product._total = product._price * product._quantity;
    }

    public double GetTotal(Product product)
    {
        return product._total;
    }

    public void GetProduct()
    {
        string formattedTotal = _total.ToString("N2");
        Console.WriteLine($"Name: {_name} ID: {_productID} Price: ${_price} Quantity: {_quantity} Item Total: ${formattedTotal}");
    }



}