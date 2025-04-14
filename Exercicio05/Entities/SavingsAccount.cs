namespace Exercicio05.Entities
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(){}
        
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            if (amount > 0)
            {
                Balance -= amount;
            }
        }
        
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}