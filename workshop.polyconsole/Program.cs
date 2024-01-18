using workshop.polyconsole;
using workshop.polyconsole.Products;

Guitar guitar1 = new Guitar() { Id=1,Name="Gibson SG", Price=999.99, Discount=5};
Drums drums1 = new Drums() { Id=2,Name="Pearl Export", Price=699.99 };

Basket basket = new Basket();
basket.AddProduct(drums1);
basket.AddProduct(guitar1);

foreach(IProduct item in basket.Products)
{
    Console.WriteLine(item.Name);

}
foreach (IDiscountable item in basket.Products.Where(x => x is IDiscountable))
{
    Console.WriteLine(item.Discount);
    Console.WriteLine((item as  IDiscountable).Discount);
    Console.WriteLine((item as IProduct).Name);

}

