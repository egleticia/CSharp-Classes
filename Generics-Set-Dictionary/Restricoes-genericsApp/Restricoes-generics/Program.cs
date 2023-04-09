using System.Globalization;
using Restricoes_generics.Services;
using Restricoes_generics.Entities;


List<Produtos> list = new List<Produtos>();

Console.WriteLine("Enter N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] vect = Console.ReadLine().Split(',');
    string name = vect[0];
    double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
    list.Add(new Produtos(name, price));
}

CalculationService calculationService = new CalculationService();

Produtos max = calculationService.Max(list);
Console.WriteLine("Max: ");
Console.WriteLine(max);
