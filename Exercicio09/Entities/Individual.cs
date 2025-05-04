namespace Exercicio09.Entities
{
    public class Individual : TaxPayer
    {
        public double HealthBills { get; set; }

        public Individual(string name, double anualIncome, double healthBills) : base(name, anualIncome)
        {
            HealthBills = healthBills;
        }

        public override double TaxesPayment()
        {
            double taxes = 0;
            taxes = AnualIncome < 20000 ? 15 : 25;
            return AnualIncome * (taxes/100) - (HealthBills*(50.0/100.0));
        }
    }
}