public class Order
{
    private List<Product> _products;
    private string _customer;
    private bool _isLocal;

    public string GetShippingLabel()
    {
        return "#";
    }

    public string GetPackingLabel()
    {
        return "#";
    }
}