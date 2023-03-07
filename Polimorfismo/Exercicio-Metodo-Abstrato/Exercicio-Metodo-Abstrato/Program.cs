

using Exercicio_Metodo_Abstrato.Entities;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;

Console.WriteLine("Enter the number of tax payers:");
int n = int.Parse(Console.ReadLine());

List<TaxPayer> list = new List<TaxPayer>();


for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data: ");

    Console.WriteLine("Individual or company (i/c)?");
    char pessoa = char.Parse(Console.ReadLine());

    Console.WriteLine("Name: ");
    string name = Console.ReadLine();

    Console.WriteLine("Anual income: ");
    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (pessoa == 'i')
    {
        Console.WriteLine("Health expenditures: ");
        double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new PessoaFisica(name, income, health));

    }

    else
    {
        Console.WriteLine("Number of employees: ");
        int employees = int.Parse(Console.ReadLine());

        list.Add(new PessoaJuridica(name, income, employees));
    }
}


Console.WriteLine("---------------------");
Console.WriteLine("TAXES PAID: ");



List<double> soma = new List<double>();

    foreach (TaxPayer payer in list)
{
    Console.WriteLine(payer.Nome + ": $ " + payer.CalculoRenda().ToString("F2", CultureInfo.InvariantCulture));

    soma.Add(payer.CalculoRenda());
}


double totalTaxes = soma.Sum();
Console.WriteLine("---------------------");
Console.WriteLine("TOTAL TAXES: " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));


