namespace Exercicio07.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomFees { get; set; }

        public ImportedProduct(string name, double price, double customFees) : base(name, price)
        {
            CustomFees = customFees;
        }
        
        public override string ToString()
        {
            return $"{Name}, R$ {Price}, Custom Fee: {CustomFees}\n";
        }
        
    }
}