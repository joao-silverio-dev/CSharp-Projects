using System;
using Exercicio04.Entities;
using Exercicio04.Entities.Enum;

namespace Exercicio04
{
    public class Program
    {
        ReadData read = new ReadData();
        DateTime date = new DateTime();
        public Program()
        {
            
            
            Console.WriteLine("Enter client data: ");
            string clientName = read.ReadString("Name: ");
            string clientEmail = read.ReadString("Email: ");
            DateTime clientBirthDate = read.ReadDateTime("Birth date (DD/MM/YYYY): ");
            Client client = new Client(clientName, clientEmail, clientBirthDate);
            
            Console.WriteLine("Enter order data: ");
            Console.WriteLine("Status: ");
            Console.WriteLine("PendingPayment / Processing / Shipped / Delivered");
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            DateTime orderTime = DateTime.Now;
            Order order = new Order(orderTime, os, client);
            
            int productQuantity = read.ReadInteger("How many items to this order? ");

            for (int i = 1; i <= productQuantity; i++)
            {
                string productName = read.ReadString("Product Name: ");
                double productPrice = read.ReadDouble("Product Price: ");
                int quantity = read.ReadInteger("Quantity: ");

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);
        }
        public static void Main(string[] args)
        {
            new Program();
        }
    }
}