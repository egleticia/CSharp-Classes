using ExtensionMethods.Extension;


// Criando um Extension Method para que dt.ElapsedTime(), seja uma chamada válida

DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
Console.WriteLine(dt.ElapsedTime());
