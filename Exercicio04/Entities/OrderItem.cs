namespace Exercicio04.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem(Product product)
        {
            
        }
        
        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}