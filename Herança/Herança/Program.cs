using System;
using Herança.Entities;

internal class Program
{
    private static void Main(string[] args)
    {

        //BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);

        //Console.WriteLine(account.Balance);

        //account.Balance = 200.00;

        //Nesta aula é possível entender os modificadores de acesso:

        //Quando é setado private é possível o acesso ao membro na própria classe, assim como nas
        // subclasses, porém não é possível alterar seu valor.Assim como é setado protected, é possível
        //acesso fora do Assembly(como por exemplo em Program.cs),porém não é possível sua alteração.


        Account acc = new Account(1001, "Alex", 0.0);
        BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.00, 500.00);

        // UPCASTING
        // Subclasse para Superclasse

        //  variável acc1 que é do tipo BusinessAcount será instanciada como Account - Upcasting
        Account acc1 = bacc;
        Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.00);
        Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

        // DOWNCASTING
        // Superclasse para Subclasse

        // variável acc2 que é do tipo Account será instanciada como BusinessAccount - Downcasting
        BusinessAccount acc4 = (BusinessAccount)acc2;
        acc4.Loan(100.00);

        // Há duas formas de dizer ao compilador qual o tipo da variável:
        // Entre parenteses na frente da variável : BusinessAccount acc5 = (BusinessAccount) acc3;
        // Utilizando 'as' : BusinessAccount acc5 = acc3 as BusinessAccount;

        //BusinessAccount acc5 = (BusinessAccount)acc3;

        // esta verificação falha pois acc3 é SavingsAccount 
        if (acc3 is BusinessAccount)
        {
            // BusinessAccount acc5 = (BusinessAccount)acc3;
            BusinessAccount acc5 = acc3 as BusinessAccount;
            acc5.Loan(200.00);
            Console.WriteLine("Loan!");
        }

        // esta verificação é correta
        if (acc3 is SavingsAccount)
        {
            //  SavingsAccount acc5 = (SavingsAccount)acc3;
            SavingsAccount acc5 = acc3 as SavingsAccount;
            acc5.UpdateBalance();
            Console.WriteLine("Update!");
        }

    }
}
