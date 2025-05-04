using System;
using System.Collections.Generic;
using Exercicio05.Entities;

namespace Exercicio05
{
    public class Program
    {
        public Program()
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0;
            
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine(sum);
            foreach (Account acc in list)
            {
                acc.Withdraw(100.0);
            }

            
            foreach (Account acc in list)
            {
                Console.WriteLine(acc.Balance);
            }

            
        }

        public static void Main(string[] args)
        {
            new Program();
        }
    }
}