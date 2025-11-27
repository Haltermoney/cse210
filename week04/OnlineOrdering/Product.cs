public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    public void SetProduct()
    {
        _name = "Product";
        _productID = "0000";
        _price = 0.00;
    }
    public void SetProduct(string name, string productID, double price)
    {
        _name = name;
        _productID = productID;
        _price = price;
    }

    public void GetProduct()
    {
        
    }



}