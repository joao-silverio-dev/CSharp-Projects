using System;
using System.Runtime.CompilerServices;

namespace Exercicio21
{
    public class PrintService
    {
        private int[] _values = new int[10];
        private int _count = 0;

        public void AddValue(int value)
        {
            _values[_count] = value;
            _count++;
        }

        public int First()
        {
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i <= _count-1; i++)
            {
                Console.Write($"{_values[i]}");
                if (i < _count-1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]");
        }
    }
}