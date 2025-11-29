public class Order
{
    private List<Product> _products = new List<Product>();
    Customer _customer = new Customer();
    private bool _isLocal;
    private double _orderTotal = 0;
    private double _shipping;
    private double _totalShipping;

    public void SetCustomer(string name)
    {
        _customer.SetCustomer(name);
    }

    public void SetCustomerAddress(string address, string city, string state, string zip, string country)
    {
        _customer.SetCustomerAddress(address, city, state, zip, country);
        if (country == "US")
        {
            _isLocal = true;
            _shipping = 5;
        }
        else
        {
            _isLocal = false;
            _shipping = 35;
        }
    }

    public void GetShippingLabel()
    {
        _customer.GetCustomer();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void AddProduct(Product product, int quantity)
    {
        product.UpdateProduct(product, quantity);
        _products.Add(product);
    }

    public void GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            product.GetProduct();
            _orderTotal += product.GetTotal(product);
        }
        _totalShipping = _orderTotal + _shipping;
        Console.WriteLine($"Total: ${_orderTotal} Shipping: ${_shipping} Total + Shipping: ${_totalShipping}");
    }
}