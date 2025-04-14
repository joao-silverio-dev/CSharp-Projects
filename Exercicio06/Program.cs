using System;
using System.Collections.Generic;
using Exercicio06.Entities;

namespace Exercicio06
{
    public class Program
    {
        public Program()
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int quantity = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsorced (y/n)? ");
                string outsorced = Console.ReadLine();
                Console.Write("Name: ");
                string employeeName = Console.ReadLine();
                Console.Write("Hours: ");
                int hoursToWork = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                if (outsorced == "y" || outsorced == "Y")
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    employees.Add(new OutsourcedEmployee(employeeName, hoursToWork, valuePerHour, additionalCharge));
                } else
                {
                    employees.Add(new Employee(employeeName, hoursToWork, valuePerHour));
                }
            }

            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.Name} - {emp.Payment()}");
            }

        }
        public static void Main(string[] args)
        {
            new Program();
        }
    }
}