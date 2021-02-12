﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise52
{
    public class Square : IShape
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