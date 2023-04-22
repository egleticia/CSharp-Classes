using Action.Entities;


// representa um método void que recebe zero ou mais argumentos 


List<Product> list = new List<Product>();
list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

//criando um objeto do tipo delegate action
Action<Product> act = UpdatePrice;

//criando com função lambda
Action<Product> act1 = p => { p.Price += p.Price * 0.10; };

list.ForEach(p => { p.Price += p.Price * 0.10; });
//list.ForEach(act);
//list.ForEach(act1);
//list.ForEach(UpdatePrice);

foreach (Product product in list)
{
    Console.WriteLine(product);
}

static void UpdatePrice(Product p)
{
    p.Price += p.Price * 0.10;
}
