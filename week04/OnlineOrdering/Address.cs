class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    //getters and setters:
    public string Street { get { return _street; } set { _street = value; } }
    public string City { get {return _city; } set { _city = value; } }
    public string State { get { return _state; } set { _state = value; } }
    public string Country { get { return _country;} set { _country = value; } }

    //constructor:
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool LivesInUSA()
    {
        if(_country.ToUpper() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetFullAddress()
    {
        return $"{Street}\n{City}, {State}\n{Country}";
    }
}