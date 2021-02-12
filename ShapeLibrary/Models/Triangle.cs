using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesInterfaceEdition
{
    public class Triangle : IShape, ITriangle
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public Triangle()
        {

        }

        public Triangle(int side1, int side2, int side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double Area()
        {
            var semiPerimeter = Perimeter() / 2;

            var area = Math.Sqrt(semiPerimeter * ((semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3)));

            return area;
        }

        public double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }
}
