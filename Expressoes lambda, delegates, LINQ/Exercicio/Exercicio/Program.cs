using System.Collections.Generic;
using Exercicio.Entities;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;

Console.WriteLine("Enter full file path: ");
string path = Console.ReadLine();


List<Products> products = new List<Products>();

using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] fields = sr.ReadLine().Split(',');
        string name = fields[0];
        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
        products.Add(new Products(name, price));

    }
}

var avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
Console.WriteLine("Average Price: " + avg.ToString("F2", CultureInfo.InvariantCulture));

var names = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

Console.WriteLine(names);

foreach (var name in names)
{
    Console.WriteLine(name);
}