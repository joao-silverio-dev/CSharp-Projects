using System;
using System.IO;

namespace Exercicio13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string sourcePath = @"/Users/silverio/Sem Título.txt";
            string targetPath = @"/Users/silverio/Sem Titulo 2.txt";
            try
            {
                FileInfo file = new FileInfo(sourcePath);
                file.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured: " + e.Message);
            }
        }
    }
}