using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Exercicio18.Entities;

namespace Exercicio18
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            string sourcePath = @"/Users/silverio/Downloads";
            string targetPath = @"/Users/silverio/Downloads";

            string[] lines = File.ReadAllLines(sourcePath + "/files1.csv");
            
            
            Directory.CreateDirectory(sourcePath + "/out");

            string targetFilePath = targetPath + "/out/summary.csv";
            using (StreamWriter sw = File.CreateText(targetFilePath))
            {
                foreach (string line in lines)
                {
                    string[] part = line.Split(';');
                
                    string productName = part[0];
                    double productPrice = double.Parse(part[1]);
                    int productQuantity = int.Parse(part[2]);

                    Product prod = new Product(productName, productPrice, productQuantity);
                    sw.WriteLine($"{prod.Name},{(prod.Price*prod.Quantity).ToString(CultureInfo.InvariantCulture)}");
                    products.Add(prod);
                }
            }

        }
    }
}