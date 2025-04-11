using System;
using System.Text;
using System.Collections.Generic;

using Exercicio04.Entities.Enum;


namespace Exercicio04.Entities
{
    public class Order
    {
        public DateTime Moment;
        public OrderStatus Status;
        Client Client;
        public List<OrderItem> Items = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.Quantity * item.Price;
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder myString = new StringBuilder();
            myString.Append($"Order Moment {Moment}\n");
            myString.Append($"Order Status {Status}\n");
            myString.Append($"Client: {Client}\n");
            foreach (OrderItem item in Items)
            {
                myString.Append(item);
            }

            myString.Append($"Total price: R$ {Total()}");

            return myString.ToString();
        }
    }
}