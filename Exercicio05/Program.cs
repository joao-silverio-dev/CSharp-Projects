using System;
using Exercicio05.Entities;

namespace Exercicio05
{
    public class Program
    {
        public Program()
        {
            Account acc1 = new Account(1001, "Alex", 500);
            Account acc2 = new SavingsAccount(1002, "Maria", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }

        public static void Main(string[] args)
        {
            new Program();
        }
    }
}