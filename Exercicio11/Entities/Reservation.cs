using System;
using Exercicio11.Entities.Exceptions;

namespace Exercicio11.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }

            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return $"Room {RoomNumber}, " +
                   $"CheckIn {CheckIn.ToString("dd/MM/yyyy")}, " +
                   $"CheckOut {CheckOut.ToString("dd/MM/yyyy")} ";
        }
    }
}