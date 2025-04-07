using System;
using Exercicio01.Entities;
using Exercicio01.Entities.Enums;

namespace Intermediario___Curso_de_Desenvolvimento_CSharp {
    public class Program {
        public Program()
        {
            Console.Clear();
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
            
            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            OrderStatus os; Enum.TryParse("Delivered", out os);
            Console.WriteLine(os);
        }
        public static void Main(string[] args)
        {
            new Program();
        }
    }
}