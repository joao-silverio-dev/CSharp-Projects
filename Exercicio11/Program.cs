using System;
using Exercicio11.Entities;
using Exercicio11.Entities.Exceptions;

namespace Exercicio11
{
    public class Program
    {
        public Program()
        {
            try
            {


                Reservation reservation;
                Console.WriteLine("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());
                reservation = new Reservation(number, checkIn, checkOut);

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine(reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        public static void Main(string[] args)
        {
            new Program();
        }
    }
}