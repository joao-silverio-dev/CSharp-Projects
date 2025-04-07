using System;
using System.Collections.Generic;
using Exercicio04.Entities.Enum;


namespace Exercicio04.Entities
{
    public class Order
    {
        public DateTime Moment = DateTime.Now;
        public OrderStatus Status;
        public List<OrderItem> orderItems = new List<OrderItem>();
        public Client Client { get; set; }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            orderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            orderItems.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in orderItems)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
    }
}