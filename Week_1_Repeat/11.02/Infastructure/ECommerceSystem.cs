using System.ComponentModel;
using Domain;

namespace Infastructure;

public class ECommerceSystem
{
    public List<Product> products { get; set; }
    public List<Customer> customers { get; set; }
    public List<Order> orders { get; set; }

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
    public void PlaceOrder(Customer customer, ShopingCart shopingCart) { }
    public void UpdateOrderStatus(string orderId, OrderStatus status)
    {
        foreach (var item in orders)
        {
            if (item.OrderId == orderId)
            {
                item.orderStatus = status;
                System.Console.WriteLine("Changed");
            }
        }
    }
    public void DisplayAllOrders()
    {
        foreach (var item in orders)
        {
            System.Console.WriteLine($"OrderId: {item.OrderId}, Customer: {item.customer.Name}, Status: {item.orderStatus}");
        }
    }
}
