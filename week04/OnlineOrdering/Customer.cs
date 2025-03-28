using System.Dynamic;

class Customer
{
    private string _name;
    private Address _address;

    public string Name { get {return _name;} set { _name = value;} }
    public Address Adress { get { return _address; } set { _address = value; } }

    public Customer(string customerName, Address currentAddress)
    {
        _name = customerName;
        _address = currentAddress;
    }


    public bool LivesInUSA()
    {
        return _address.LivesInUSA();
    }

    public string GetCustomerInformation()
    {
        return $"Name: {Name}\nAddress:\n{_address.GetFullAddress()}";
    }
}