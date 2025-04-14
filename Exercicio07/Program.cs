using System;
using Exercicio07.Entities;

namespace Exercicio07
{
    public class Program
    {
        public Program()
        {
            Console.Write("Enter the number of products: ");
            int quantity = int.Parse(Console.ReadLine());
            for (int i = 0; i <= quantity; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                
                Console.WriteLine();
                Console.Write("Name: ");
                string productName = Console.ReadLine();
                
            }
        }
        public static void Main(string[] args)
        { }
    }
}