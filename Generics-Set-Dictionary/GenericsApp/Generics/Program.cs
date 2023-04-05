using Generics;



PrintService printService= new PrintService();
Console.WriteLine("How many Values? ");
int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    printService.addValue(x);
}

printService.Print();
Console.WriteLine("First: " + printService.First());