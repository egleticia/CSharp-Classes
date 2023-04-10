using GetHashCode_Equals.Entities;


// foi definido como criterio o email do cliente, assim se os dois emails forem iguais, o retorno será true

Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };


Console.WriteLine(a.Equals(b));
Console.WriteLine(a == b);
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
