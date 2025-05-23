using System;
using Exercicio01.Entities.Enums;

namespace Exercicio01.Entities {
    public class Order {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Moment}, {Status}";
        }
    }
}