using Predicate.Entities;
using System.Collections.Generic;

// delegate: referência a uma função
// predicate: recebe um objeto do tipo T e retorna um valor booleano

List<Product> list = new List<Product>();
list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

//list.RemoveAll(p => p.Price >= 100);
list.RemoveAll(ProductTest);

foreach (var item in list)
{
    Console.WriteLine(item);
}

static bool ProductTest(Product product)
{
    return product.Price >= 100;
}
