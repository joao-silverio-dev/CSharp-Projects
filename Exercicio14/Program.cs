using System;
using System.IO;

namespace Exercicio14
{
    public class Program
    {
        public Program()
        {
            string sourcePath = @"/Users/silverio/Sem Titulo.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(sourcePath);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }

        public static void Main(string[] args)
        {
            new Program();
        }
    }
}