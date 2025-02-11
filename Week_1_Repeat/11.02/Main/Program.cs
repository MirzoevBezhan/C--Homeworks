using Domain;
using Infastructure;


ECommerceSystem eCommerceSystem = new ECommerceSystem();
Product product1 = new Product();
Customer customer = new Customer();
ShopingCart shopingCart = new ShopingCart();

customer.Name="Bezhn";
customer.CustomerId="2";


product1.Name="Yogurt";
product1.Price=222;
product1.ProductId="23";

shopingCart.AddToCart(product1,2);

eCommerceSystem.AddCustomer(customer);
eCommerceSystem.AddProduct(product1);
eCommerceSystem.PlaceOrder(customer,shopingCart);

eCommerceSystem.DisplayAllOrders();