using System;

namespace Exercicio07.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string ToString()
        {
            return $"{Name}, R$ {Price}, Custom Fee: {ManufactureDate.ToString("d")}\n";
        }
    }
}