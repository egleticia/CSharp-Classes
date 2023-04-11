using System.Collections.Generic;

//Representa conjunto de elementos: não permite repetições, elementos não possuem posição, acesso, inserção e remoção de elementos são rápidos


// instânciando um conjunto
HashSet<string> set = new HashSet<string>();

set.Add("TV");
set.Add("Notebook");
set.Add("Tablet");


foreach (string p in set)
    Console.WriteLine(p);

Console.WriteLine("-------------------------------------");

// SortedSet mantém os elementos ordenados
SortedSet<int> a = new SortedSet<int>()
{
    10,0,2,4,5,6,8
};

SortedSet<int> b = new SortedSet<int>()
{
    5,6,7,8,9,10
};

//Union 
SortedSet<int> c = new SortedSet<int>(a);
c.UnionWith(b);

PrintCollection(c);

//Intersection 
SortedSet<int> d = new SortedSet<int>(a);
d.IntersectWith(b);

PrintCollection(d);

//Difference 
SortedSet<int> e = new SortedSet<int>(a);
e.ExceptWith(b);

PrintCollection(e);


static void PrintCollection<T>(IEnumerable<T> collection)
{
    //foreach funciona em cima de coleções que implementam o IEnumerable
    foreach (T obj in collection)
    {
        Console.Write(obj + " ");
    }
    Console.WriteLine();
}
