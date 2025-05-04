using System;

namespace Exercicio07.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string PriceTag()
        {
            return $"{Name} - R$ {Price}";
        }

        public override string ToString()
        {
            return $"{Name}, R$ {Price}\n";
        }
    }
}