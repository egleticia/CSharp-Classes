using System;
using System.Collections.Generic;
using System.Globalization;
using Herança.Entities;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        //        BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);

        //        Console.WriteLine(account.Balance);

        //        account.Balance = 200.00;

        //        Nesta aula é possível entender os modificadores de acesso:

        //        Quando é setado private é possível o acesso ao membro na própria classe, assim como nas
        //         subclasses, porém não é possível alterar seu valor.Assim como é setado protected, é possível
        //        acesso fora do Assembly(como por exemplo em Program.cs),porém não é possível sua alteração.


        //         Início Aula II -----------------------------------------------------------------

        //        Account acc = new Account(1001, "Alex", 0.0);
        //    BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.00, 500.00);

        //    UPCASTING
        //    Subclasse para Superclasse

        //          variável acc1 que é do tipo BusinessAcount será instanciada como Account - Upcasting
        //        Account acc1 = bacc;
        //        Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.00);
        //    Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

        //    DOWNCASTING
        //    Superclasse para Subclasse

        //         variável acc2 que é do tipo Account será instanciada como BusinessAccount - Downcasting
        //        BusinessAccount acc4 = (BusinessAccount) acc2;
        //    acc4.Loan(100.00);

        //         Há duas formas de dizer ao compilador qual o tipo da variável:
        //         Entre parenteses na frente da variável : BusinessAccount acc5 = (BusinessAccount)acc3;
        //    Utilizando 'as' : BusinessAccount acc5 = acc3 as BusinessAccount;

        //    BusinessAccount acc5 = (BusinessAccount)acc3;

        //    esta verificação falha pois acc3 é SavingsAccount 
        //        if (acc3 is BusinessAccount)
        //        {
        //             BusinessAccount acc5 = (BusinessAccount)acc3;
        //    BusinessAccount acc5 = acc3 as BusinessAccount;
        //    acc5.Loan(200.00);
        //            Console.WriteLine("Loan!");
        //        }

        //esta verificação é correta
        //        if (acc3 is SavingsAccount)
        //        {
        //    SavingsAccount acc5 = (SavingsAccount)acc3;
        //    SavingsAccount acc5 = acc3 as SavingsAccount;
        //    acc5.UpdateBalance();
        //    Console.WriteLine("Update!");
        //}
        // Fim Aula II -----------------------------------------------------------------




        // Início Aula III -----------------------------------------------------------------

        //Account acc1 = new Account(1001, "Alex", 500.00);
        //Account acc2 = new SavingsAccount(1002, "Anna", 500.00, 0.01);

        //acc1.Withdraw(10.0);
        //acc2.Withdraw(10.0);


        //Console.WriteLine(acc1.Balance);
        //Console.WriteLine(acc2.Balance);


        // Sobrescrita - quando você implementa (alterando ou não) na subclasse a operação que já existia na superclasse
        // base - chama a implementação da superclasse usando palavra 'base'
        // virtual - permite que o método principal seja sobrescrito pelas subclasses
        // override - para sobrescrever o método principal é necessário incluir o prefixo override

        // Fim Aula III -----------------------------------------------------------------


        // Início Aula V - Classes Abstratas -----------------------------------------------------------------

        List<Account> list = new List<Account>();

        list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
        list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
        list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
        list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

        double sum = 0.0;
        foreach (Account account in list) {

            sum += account.Balance;
        }

        Console.WriteLine("Total Balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

        foreach (Account acc in list)
        {
            acc.Withdraw(10.0);
        }

        foreach (Account acc in list)
        {
            Console.WriteLine($"Update balance for account" 
                + acc.Number + " " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
