using System;

namespace Exercicio04.Entities
{
    public class ReadData
    {
        public int ReadInteger(string msg)
        {
            int value;
            Console.Write(msg);
            while (int.TryParse(Console.ReadLine(), out value) == false)
            {
                Console.WriteLine("Error, try a integer number");
                Console.Write(msg);
            }
            return value;
        }

        public double ReadDouble(string msg)
        {
            double value;
            Console.Write(msg);
            while (double.TryParse(Console.ReadLine(), out value) == false)
            {
                Console.WriteLine("Error, try a integer number");
                Console.Write(msg);
            }
            return value;
        }

        public string ReadString(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }

        public DateTime ReadDateTime(string msg)
        {
            Console.Write(msg);
            return DateTime.Parse(Console.ReadLine());
        }
    }
}