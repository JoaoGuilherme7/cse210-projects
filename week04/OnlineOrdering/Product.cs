public class Product{
    private string _name { get; set; }
    private string _id { get; set; }
    private decimal _price { get; set; }
    private int _quantity { get; set; }
    
    //constuctor
    public Product(string name, string id, decimal price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotalPrice()
    {
        return _price * _quantity;
    }

    // Getters and Setters
    public string GetName()
    {
        return _name;
    }
    public string GetProductID()
    {
        return _id;
    }
    public decimal GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity    ;
    }    


    public void SetName(string name)
    {
        _name = name;
    }
    public void SetProductID(string id)
    {
        _id = id;
    }
    public void SetPrice(decimal price)
    {
        _price = price;
    }
    public void SetQuantity(int quantity)
    {
        if (quantity > 0)
        {
            _quantity = quantity;
        }
    }    
}