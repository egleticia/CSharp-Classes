
using System.Globalization;
using AluguelDeCarros.Entities;

Console.WriteLine("Enter rental data: ");
Console.WriteLine("Car model: ");
string model = Console.ReadLine();

Console.WriteLine("Pickup: ");
DateTime start = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.WriteLine("Return: ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

CarRental carRental = new CarRental(start, finish, new Vehicle(model));


