namespace Domain;

public class Order
{
    public string OrderId { get; set; }
    public Customer customer { get; set; }
    public List<Order> OrderedItems { get; set; }
    public double TotalAmount { get; set; }
    public DateTime OrderDate { get; set; }
    public OrderStatus orderStatus;

    public void UpdateStatus(OrderStatus status)
    {
      orderStatus=status;
      System.Console.WriteLine("Changed");
    }
    
}
