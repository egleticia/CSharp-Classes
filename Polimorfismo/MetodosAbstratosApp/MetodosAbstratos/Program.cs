using MetodosAbstratos.Entities;
using MetodosAbstratos.Entities.Enums;
using System.ComponentModel;
using System.Globalization;

List<Shape> list = new List<Shape>();

Console.WriteLine("Enter the number of shapes: ");
int n = int.Parse(Console.ReadLine());


for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Shape #{i} data: ");
    Console.WriteLine("Rectangle or Circle (r/c)? ");
    char ch = Char.Parse(Console.ReadLine());
    Console.WriteLine("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());

    if (ch == 'r')
    {
        Console.WriteLine("Width: ");
        double width = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Height: ");
        double height = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new Rectangle(width, height, color));
    }
    else
    {
        Console.WriteLine("Radius: ");
        double radius = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new Circle(radius, color));
    }
}

    Console.WriteLine("-----------------");
    Console.WriteLine("SHAPE AREAS: ");

    foreach(Shape shape in list)
    {
        Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
    }


