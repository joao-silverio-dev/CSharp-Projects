using System;
using Exercicio19.Entities;
using Exercicio19.Services;

namespace Exercicio19
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("Enter rental data: ");
            Console.Write("Car Model: ");
            string carModel = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime pickUpTime = DateTime.Parse(Console.ReadLine());
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime returnTime = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine());
            Console.Write("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine());
            
            CarRental carRental = new CarRental(pickUpTime, returnTime, new Vehicle(carModel));

            RentalService rentalService = new RentalService(pricePerHour, pricePerDay);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Invoice);
        }

        public static void Main(string[] args)
        {
            new Program();
        }
    }
}