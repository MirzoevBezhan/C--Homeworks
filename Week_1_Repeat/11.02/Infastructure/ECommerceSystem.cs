using System.ComponentModel;
using Domain;

namespace Infastructure;

public class ECommerceSystem
{
    public List<Product> products { get; set; } = new List<Product>();
    public List<Customer> customers { get; set; } = new List<Customer>();
    public List<Order> orders { get; set; } = new List<Order>();
    public void AddProduct(Product product)
    {
        products.Add(product);
        System.Console.WriteLine("Added");
    }
    public void AddCustomer(Customer customer)
    {
        customers.Add(customer);
        System.Console.WriteLine("Added");
    }
    public void PlaceOrder(Customer customer, ShopingCart shopingCart)
    {
        decimal TotalAmount = 0;
        foreach (var item in shopingCart.Cart)
        {
            TotalAmount += item.Key.Price * item.Value;
        }
        Order order2 = new Order(customer, shopingCart.Cart, TotalAmount);
        orders.Add(order2);
        System.Console.WriteLine("Success");
    }
    public void UpdateOrderStatus(string orderId, OrderStatus status)
    {
        foreach (var item in orders)
        {
            if (item.OrderId == orderId)
            {
                item.Status = status;
                System.Console.WriteLine("Changed");
            }
            else
            {
                System.Console.WriteLine("Error");
            }
        }
    }
    public void DisplayAllOrders()
    {
        foreach (var item in orders)
        {
            System.Console.WriteLine($"OrderId: {item.OrderId}, Customer: {item.customer.Name}, Status: {item.Status}, OrderDate: {item.OrderDate}, Total: {item.TotalAmount}");
        }
    }
}
