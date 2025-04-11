namespace Exercicio04.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            this.Product = product;
        }

        public override string ToString()
        {
            return $"{Product.Name}, R$ {Product.Price}, Subtotal: ${Product.Price * Quantity}\n";
        }
    }
}