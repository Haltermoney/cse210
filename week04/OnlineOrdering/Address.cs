public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _postalCode;
    private string _country;

    public Address()
    {
        _streetAddress = "";
        _city = "";
        _state = "";
        _postalCode = "00000";
        _country = "US";
    }

    public void SetAddress(string address, string city, string state, string zip, string country)
    {
        _streetAddress = address;
        _city = city;
        _state = state;
        _postalCode = zip;
        _country = country;
    }

    public void SetAddress(string address, string city, string zip, string state)
    {
        _streetAddress = address;
        _city = city;
        _state = state;
        _postalCode = zip;
        _country = "US";
    }

    public bool IsLocal()
    {
        if (_country == "US")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        if (_country == "US")
        {
            return $"{_streetAddress}\n{_city}, {_state} {_postalCode}";
        }
        else
        {
            return $"{_streetAddress}\n{_city}, {_state} {_postalCode}\n{_country}";
        }
    }
}