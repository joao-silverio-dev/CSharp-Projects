using System;
using Exercicio12.Entities.Exceptions;

namespace Exercicio12.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double WithdrawLimit { get; set; }
        public double Balance { get; set; }
        

        public Account(int number, string holder, double withdrawLimit, double initialBalance)
        {
            Number = number;
            Holder = holder;
            WithdrawLimit = withdrawLimit;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance <= amount || amount > WithdrawLimit)
            {
                throw new AccountException("Not enough value on Balance or value exceeds withdraw limit");
            }
            Balance -= amount;
        }
        
        
    }
}