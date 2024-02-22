public class Order 
{
    private List<Product> products;
    private Customer _customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        totalCost += _customer.LivesInUSA() ? 5 : 35;
        return totalCost;
    }

    public string GeneratePackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GenerateShippingLabel()
    {
        string label = $"Shipping Label\n\n{_customer.GetName()}\n";
        label += $"{_customer.GetAddress().ToString()}\n";
        return label;
    }
}