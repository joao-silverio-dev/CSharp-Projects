using System;
using System.Collections.Generic;
using Exercicio08.Entities;
using Exercicio08.Entities.Enums;

namespace Exercicio08
{
    public class Program
    {
        Program()
        {
            List<Shape> shapes = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfShapes; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char rectOrCirc = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());

                switch (rectOrCirc)
                {
                    case 'r':
                        Console.Write($"Height: ");
                        double height = double.Parse(Console.ReadLine());
                        Console.Write($"Width: ");
                        double width = double.Parse(Console.ReadLine());
                        shapes.Add(new Rectangle(width, height, color));
                        break;
                    case 'c':
                        Console.Write($"Radius: ");
                        double radius = double.Parse(Console.ReadLine());
                        shapes.Add(new Circle(radius, color));
                        break;
                    default:
                        Console.WriteLine("Invalidate");
                        break;
                }
            }
            Console.WriteLine("Shape Areas: ");
            foreach (Shape shp in shapes)
            {
                Console.WriteLine(shp.Area());
            }
        }
        public static void Main(string[] args)
        {
            new Program();
        }
    }
}