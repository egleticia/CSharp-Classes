using ExecicioFixacao_Excecoes.Exceptions;
using System.Globalization;

namespace ExecicioFixacao_Excecoes.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }


        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            

            if (amount > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance.");
            }

            if (amount > WithDrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit.");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
