using System;

namespace Exercicio21
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PrintService printar = new PrintService();

            printar.AddValue(int.Parse(Console.ReadLine()));
            printar.AddValue(int.Parse(Console.ReadLine()));
            printar.AddValue(int.Parse(Console.ReadLine()));

            Console.WriteLine(printar.First());
            printar.Print();
        }
    }
}