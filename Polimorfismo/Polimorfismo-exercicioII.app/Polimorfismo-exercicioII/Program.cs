

using Microsoft.VisualBasic;
using Polimorfismo_exercicioII.Entities;
using System.Diagnostics;
using System.Globalization;


Console.WriteLine("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

List<Product> list = new List<Product>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.WriteLine("Common, used or imported (c/u/i)?");
    char status = Char.Parse(Console.ReadLine());

    Console.WriteLine("Name:");
    string name = Console.ReadLine();

    Console.WriteLine("Price: ");
    double price = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (status == 'i')
    {
        Console.WriteLine("Customs fee: ");
        double customsFee = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new ImportedProduct(name, price, customsFee));
    }

    else if (status == 'u')
    {
        Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
        list.Add(new UsedProduct(name, price, manufactureDate));
    }

    else
    {
        list.Add(new Product(name, price));
    }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS:");

foreach (Product product in list)
{
    Console.WriteLine(product.priceTag());
}
