namespace Domain;

public class ShopingCart
{
 public Dictionary<Product,int> CartItems = new Dictionary<Product, int>();
 public void AddToCart(Product product,int quantity){
    CartItems.Add(product,quantity);
    System.Console.WriteLine("Added");
 }

}
