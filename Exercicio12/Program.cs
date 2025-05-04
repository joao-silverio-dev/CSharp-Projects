using System;
using Exercicio12.Entities;
using Exercicio12.Entities.Exceptions;

namespace Exercicio12
{
    public class Program
    {
        public Program()
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int accNum = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string accHolder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double initBal = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account acc = new Account(accNum, accHolder, withdrawLimit, initBal);
                Console.Write("Enter amount for withdraw: ");
                acc.Withdraw(double.Parse(Console.ReadLine()));
                Console.WriteLine("New Balance: " + acc.Balance);
            }
            catch (AccountException e)
            {
                Console.WriteLine("Withdraw Error: " + e.Message);
            }
            
        }
        public static void Main(string[] args)
        {
            new Program();
        }
    }
}