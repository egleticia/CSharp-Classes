using InterfaceEHerança.Model.Entities;
using InterfaceEHerança.Model.Enums;


IShape s1 = new Circle()
{
    Radius = 2.00,
    Color = Color.White
};

IShape s2 = new Rectangle()
{
    Width = 3.50,
    Height = 4.20,
    Color = Color.Black
};

Console.WriteLine(s1);
Console.WriteLine(s2);