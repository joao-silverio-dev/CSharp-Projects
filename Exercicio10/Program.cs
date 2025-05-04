using System;

namespace Exercicio10
{
    public class Program
    {
        public Program()
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Zero Error! " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("String Error! ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Very large number! ");
            }
            
            
        }
        public static void Main(string[] args)
        {
            new Program();
        }
    }
}