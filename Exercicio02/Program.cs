using System;
using Exercicio02.Entities;
using Exercicio02.Entities.Enums;

namespace Exercicio02
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("Enter department's name: ");
            string departmentName = Console.ReadLine();
            Console.WriteLine("Enter worker's data: ");
            Console.WriteLine("Name: ");
            string workerName = Console.ReadLine();
            Console.WriteLine("Level (Junior, MidLevel, Senior): ");
            WorkerLevel workerLevel;
            Enum.TryParse(Console.ReadLine(), out workerLevel);
            Console.WriteLine("Base Salary: ");
            double workerBaseSalary = double.Parse(Console.ReadLine());
            Department dept = new Department(departmentName);
            Worker worker = new Worker(workerName, workerLevel, workerBaseSalary, dept);

            Console.WriteLine("How many Contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month)}");
        }

        public static void Main(string[] args)
        {
            new Program();
        }
    }
}