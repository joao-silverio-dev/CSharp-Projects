namespace Exercicio09.Entities
{
    public class Company : TaxPayer
    {
        public int EmployeeNumber { get; set; }

        public Company(string name, double anualIncome, int employeeNumber) : base(name, anualIncome)
        {
            EmployeeNumber = employeeNumber;
        }

        public override double TaxesPayment()
        {
            double taxes = 0;
            taxes = EmployeeNumber < 10 ? 16 : 14;
            return AnualIncome * (taxes/100);
        }
        
    }
}