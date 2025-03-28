class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Customer Customer { get { return _customer; } set { _customer = value; } }
    public List<Product> Products { get { return _products; } }
    
    public Order(Customer Customer)
    {
        _customer = Customer;
        _products = new List<Product>();
    }

    public float TotalPrice()
    {
        float total = 0;
        foreach (Product Product in _products)
        {
            total += Product.TotalCost();
        }
        return total;
    }

    public int ShippingCost()
    {
        if (_customer.LivesInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach(Product Product in _products)
        {
            label += $"{Product.productName} - {Product.idProduct}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.Adress.GetFullAddress()}";
    }
}