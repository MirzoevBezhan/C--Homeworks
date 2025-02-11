namespace Domain;

public class Order
{
    public string OrderId { get; set; }
    public Customer customer { get; set; }
    public Dictionary<Product,int> OrderedItems { get; set; }
    public decimal TotalAmount { get; set; }
    public DateTime OrderDate { get; set; }
    public OrderStatus Status;

    public Order(Customer customer, Dictionary<Product,int> order,decimal TotalAmount)
    {
      OrderId=Guid.NewGuid().ToString();
         this.customer=customer;
         this.OrderedItems=order;
         this.TotalAmount=TotalAmount;
         this.Status=OrderStatus.Placed;
         OrderDate=DateTime.Now;
    }
}
