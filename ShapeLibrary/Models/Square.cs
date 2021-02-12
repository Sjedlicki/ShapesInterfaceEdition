using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesInterfaceEdition
{
    public class Square : IShape, ISquare
    {
        public int Length { get; set; }

        public Square()
        {

        }

        public Square(int length)
        {
            Length = length;
        }

        public double Area()
        {
            return Length * Length;
        }

        public double Perimeter()
        {
            return Length * 4;
        }
    }
}
