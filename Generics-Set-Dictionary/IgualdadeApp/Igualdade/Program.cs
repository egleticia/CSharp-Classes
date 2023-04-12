using Igualdade.Entities;

HashSet<Product> a = new HashSet<Product>();
a.Add(new Product("TV", 900.00));
a.Add(new Product("Notebook", 1200.00));


HashSet<Point> b = new HashSet<Point>();
b.Add(new Point(3,4));
b.Add(new Point(5,10));

Product prod = new Product("Notebook", 1200.00);

// Retorno "False", embora seja o mesmo conteúdo, pois compara as referências de memória dos objetos, eram dois objetos diferentes, por isso falso;
// Após a implementação do override de Equals e HashCode o retorno é verdadeiro, pois compara o conteúdo
Console.WriteLine(a.Contains(prod));

// No caso de Point, mesmo não implementando o HashCode e Equals, o retorno é verdade, pois o tipo é STRUCT, e assim compara por conteúdo e não referência
Point p = new Point(3,4);
Console.WriteLine(b.Contains(p));