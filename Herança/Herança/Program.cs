using System;
using Herança.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        
        BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);

        Console.WriteLine(account.Balance);

        //account.Balance = 200.00;

       // Nesta aula é possível entender os modificadores de acesso:

       //Quando é setado private é possível o acesso ao membro na própria classe, assim como nas
       // subclasses, porém não é possível alterar seu valor. Assim como é setado protected, é possível
       // acesso fora do Assembly (como por exemplo em Program.cs),porém não é possível sua alteração.

    }
}
