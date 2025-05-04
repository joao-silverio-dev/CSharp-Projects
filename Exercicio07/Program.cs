using System;
using System.Collections.Generic;
using Exercicio07.Entities;

namespace Exercicio07
{
    public class Program
    {
        public Program()
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int quantity = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write($"Common, used or imported (c/u/i)? ");
                char productStats = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Write("Name: ");
                string productName = Console.ReadLine();
                Console.Write("Price: ");
                double productPrice = double.Parse(Console.ReadLine());

                switch (productStats)
                {
                    case 'c':
                        products.Add(new Product(productName, productPrice));
                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine());
                        products.Add(new ImportedProduct(productName, productPrice, customsFee));
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(productName, productPrice, manufactureDate));
                        break;
                }
            }
            foreach (Product prod in products)
            {
                Console.WriteLine(prod);
            }
        }

        public static void Main(string[] args)
        {
            new Program();
        }
    }
}