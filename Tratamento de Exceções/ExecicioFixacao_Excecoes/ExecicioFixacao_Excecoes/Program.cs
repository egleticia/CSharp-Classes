
using ExecicioFixacao_Excecoes;
using ExecicioFixacao_Excecoes.Entities;
using ExecicioFixacao_Excecoes.Exceptions;
using System.Globalization;

try
{

    Console.WriteLine("Enter account data: ");

    Console.WriteLine("Number: ");
    int number = int.Parse(Console.ReadLine());

    Console.WriteLine("Holder: ");
    string holder = Console.ReadLine();

    Console.WriteLine("Initial balance: ");
    double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Enter amount for withdraw: ");
    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Account account = new Account(number, holder, balance, withdrawLimit);

    account.WithDraw(amount);
    Console.WriteLine("New balance: " + account);

}

catch (DomainException e)
{
    Console.WriteLine(e.Message);
}