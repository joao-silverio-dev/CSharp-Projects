using System;
using System.IO;

namespace Exercicio15
{
    internal class Program
    {
        public Program()
        {
            string path = @"/Users/silverio/Sem Titulo.txt";
            string target = @"/Users/silverio/Sem Titulo 2.txt";

            try
            {
                string[] lines = File.ReadAllLines(path);
                using (StreamWriter sw = File.AppendText(target))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
        public static void Main(string[] args)
        {
            new Program();
        }
    }
}