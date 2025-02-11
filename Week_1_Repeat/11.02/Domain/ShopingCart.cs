namespace Domain;

public class ShopingCart
{
   public Dictionary<Product, int> Cart { get; set; } = new Dictionary<Product, int>();
   public void AddToCart(Product product, int quantity)
   {
      Cart.Add(product, quantity);
      System.Console.WriteLine("Added");
   }

}
