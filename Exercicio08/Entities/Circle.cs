using System;
using Exercicio08.Entities.Enums;

namespace Exercicio08.Entities
{
    public class Circle : Shape
    {
        public const double PI = 3.14;
        public double Radius { get; set; }
        
        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return PI * Math.Pow(Radius, 2);
        }
    }
}