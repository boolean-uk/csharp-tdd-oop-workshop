using workshop.inheritcons;
using workshop.inheritcons.Products;

Guitar strat = new Guitar() { Id = 1, Name = "Fender Stratocaster", Price = 1000.00, Discount = 25 };
Guitar tele = new Guitar() { Id = 2, Name = "Fender Telecaster", Price = 800, Discount = 25 };

Drums mapex = new Drums() { Id=3, Name="Mapex Drums", Price=800, Discount=100};

List<Product> products = new List<Product>();

products.Add(strat);
products.Add(tele);
products.Add(mapex);


foreach(Product product in products)
{
    Console.WriteLine($"{product.Name} £{product.CalculateDiscount()}");
}