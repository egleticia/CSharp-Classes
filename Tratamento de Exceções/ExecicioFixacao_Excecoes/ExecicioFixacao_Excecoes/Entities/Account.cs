using ExecicioFixacao_Excecoes.Exceptions;
using ExercicioFixaxao_Excecoes.Exceptions;

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
        }

        public void WithDraw(double amount)
        {

            //if (amount > balance)
            //{
            //    throw new DomainException("Not enough balance");
            //}
        }
    }
}
