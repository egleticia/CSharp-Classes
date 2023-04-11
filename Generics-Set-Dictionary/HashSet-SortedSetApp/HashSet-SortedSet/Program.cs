using System.Collections.Generic;

//Representa conjunto de elementos: não permite repetições, elementos não possuem posição, acesso, inserção e remoção de elementos são rápidos


// instânciando um conjunto
HashSet<string> set = new HashSet<string>();

set.Add("TV");
set.Add("Notebook");
set.Add("Tablet");


foreach (string p in set)
    Console.WriteLine(p);