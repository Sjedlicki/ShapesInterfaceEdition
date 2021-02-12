using System;

namespace ShapesInterfaceEdition
{
    public class Circle : IShape, ICircle
    {
        public int Radius { get; set; }

        public Circle()
        {

        }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
