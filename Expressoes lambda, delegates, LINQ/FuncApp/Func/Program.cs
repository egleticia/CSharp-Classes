using Func.Entities;
using System.Data;
using System.Linq;


// Func - Diferente de IAction, é retornado um valor 



List<Product> list = new List<Product>();
list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));



//List<string> result = list.Select(NameUpper).ToList();
Func<Product, string> func = NameUpper;
Func<Product, string> func1 = p => p.Name.ToUpper();
List<string> result = list.Select(func1).ToList();
List<string> result1 = list.Select(p => p.Name.ToUpper()).ToList();


foreach (string s in result1)
{
    Console.WriteLine(s);
}


static string NameUpper(Product p)
{
    return p.Name.ToUpper();
}


