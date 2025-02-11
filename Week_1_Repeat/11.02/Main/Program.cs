using Domain;
using Infastructure;

ECommerceSystem eCommerceSystem = new ECommerceSystem();
Customer customer = new Customer();
customer.Name="Bezhn";
customer.CustomerId="2";
eCommerceSystem.AddCustomer(customer);
Product product = new Product();
product.Name="Yogurt";
product.Price=222;
product.ProductId="23";
eCommerceSystem.AddProduct(product);