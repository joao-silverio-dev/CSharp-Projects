using Exercicio08.Entities.Enums;

namespace Exercicio08.Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }
        
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}