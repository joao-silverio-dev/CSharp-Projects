using System;
using System.IO;

namespace Exercicio17
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = @"/Users/silverio/RiderProjects";
            Console.WriteLine(Path.DirectorySeparatorChar);
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
            Console.WriteLine("Get Temp Path" + Path.GetTempPath());
        }
    }
}