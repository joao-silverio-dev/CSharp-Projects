using System;
using System.IO;
using System.Collections.Generic;

namespace Exercicio16
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = @"/Users/silverio/myFolder";

            try
            {
                var folders = 
                    Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                var files = 
                    Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "/newFolder");
            }
            
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}