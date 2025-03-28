class Product
{
    private string _productName;
    private string _idProduct;
    private float _price;
    private int _quantity;

    //Getters and Setters:
    public string productName { get { return _productName; } set { _productName = value; } }
    public string idProduct { get { return _idProduct; } set { _idProduct = value; } }
    public float price { get { return _price; } set { _price = value; } }
    public int quantity { get { return _quantity; } set { _quantity = value; } }


    //constructors:
    public Product(string name, string id, float price, int quantity)
    {
        _productName = name;
        _idProduct = id;
        _price = price;
        _quantity = quantity;
    }

    public float TotalCost()
    {
        return _price * _quantity;
    }

}