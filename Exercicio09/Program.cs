using System;
using System.Collections.Generic;
using Exercicio09.Entities;
using Exercicio09.Entities.Enums;

namespace Exercicio09
{
    public class Program
    {
        public Program()
        {
            List<TaxPayer> payers = new List<TaxPayer>();
            
            Console.Write("Enter the number of tax payers: ");
            int quantityOfTaxPayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantityOfTaxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or Company (Indivual/Company): ");
                PayerType payerType = (PayerType)Enum.Parse(typeof(PayerType), Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                
                switch ((int)payerType)
                {
                    case 1:
                        Console.Write("Health expenditures: ");
                        double healthExpenditures = double.Parse(Console.ReadLine());
                        payers.Add(new Individual(name, anualIncome, healthExpenditures));
                        break;
                    case 2:
                        Console.Write("Number of employees: ");
                        int numberOfEmployees = int.Parse(Console.ReadLine());
                        payers.Add(new Company(name, anualIncome, numberOfEmployees));
                        break;
                }
            }

            Console.WriteLine();
            double sum = 0;
            foreach (TaxPayer payer in payers)
            {
                Console.WriteLine($"{payer.Name}: {payer.TaxesPayment()}\n");
                sum += payer.TaxesPayment();
            }
        }

        public static void Main(string[] args)
        {
            new Program();
        }
    }
}