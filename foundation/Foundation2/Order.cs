using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> Products { get; set; } = new List<Product>();
    private Customer OrderCustomer { get; set; }
    private const double DomesticShippingCost = 5.00;
    private const double InternationalShippingCost = 35.00;

    public Order(Customer customer)
    {
        OrderCustomer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in Products)
        {
            totalPrice += product.GetTotalCost();
        }

        double shippingCost = OrderCustomer.LivesInUSA() ? DomesticShippingCost : InternationalShippingCost;
        totalPrice += shippingCost;

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += $"{product.Name} (Product ID: {product.ProductId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{OrderCustomer.Name}\n{OrderCustomer.CustomerAddress.GetFormattedAddress()}\n";
    }
}