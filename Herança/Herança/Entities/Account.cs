
namespace Herança.Entities
{
    public class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }

        public double Balance { get; protected set; }

        public Account() 
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

       // virtual - permite que o método principal seja sobrescrito pelas subclasses
        public virtual void Withdraw (double amount) { 

            Balance -= amount + 5.00;
        }


        
        public void Deposit( double amount) {
        
            Balance += amount;
        }

    }


}
