using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise52
{
    public class Circle : IShape
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
