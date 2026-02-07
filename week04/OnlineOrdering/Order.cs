public class Order{
    private List<Product> _products { get; set; }
    private Customer _customer { get; set; }

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public decimal CalculateTotalPrice()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalPrice();
        }
        return total + calculateFreight();
    }

    public string GetPackingLabel()
    {
        string packingLabel =  "";
        foreach (var product in _products)
        {
            packingLabel += product.GetName() + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return _customer.GetAddress().GetFullAddress();
    }

    private int calculateFreight()
    {
        return _customer.LivesInUSA() ? 5 : 35;
    }

    // Getters and Setters
    public List<Product> GetProducts()
    {
        return _products;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }



    public void SetProducts(List<Product> products)
    {
        _products = products;
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }


}