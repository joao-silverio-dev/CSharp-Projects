using System;
using Exercicio04.Entities;
using Exercicio04.Entities.Enum;

namespace Exercicio04
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter order data: ");
            Console.Write("Status (PendingPayment, Processing, Shipped, Delivered): ");
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            Console.Write("How many items to this order? ");
            int orderQuantity = int.Parse(Console.ReadLine());
            for (int i = 1; i <= orderQuantity; i++)
            {
                string productName = Console.ReadLine();
                double productPrice = double.Parse(Console.ReadLine());
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                

            }
            

        }

        public static void Main(string[] args)
        {
            new Program();
        }
    }
}