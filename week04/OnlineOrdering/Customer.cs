public class Customer
{
    private string _name;
    Address _address = new Address();

    public void SetCustomerAddress(string address, string city, string state, string zip, string country)
    {
        _address.SetAddress(address, city, state, zip, country);
    }

    public void SetCustomer(string name)
    {
        _name = name;
        _address = new Address();
    }

    public void GetCustomer()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine(_address.GetAddress());
    }
}