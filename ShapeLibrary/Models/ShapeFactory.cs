using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesInterfaceEdition
{
    public static class ShapeFactory
    {
        public static IShape GetShape(string id)
        {
            switch (id)
            {
                case "1":
                    Console.Write($"Enter a side length: ");

                    var side = int.Parse(Console.ReadLine());

                    return new Square(side);

                case "2":
                    Console.Write($"Enter the first side of a triangle: ");
                    var side1 = int.Parse(Console.ReadLine());

                    Console.Write($"Enter the second side of a triangle: ");
                    var side2 = int.Parse(Console.ReadLine());

                    Console.Write($"Enter the third side of a triangle: ");
                    var side3 = int.Parse(Console.ReadLine());

                    return new Triangle(side1, side2, side3);

                case "3":
                    Console.Write($"Enter the radius: ");

                    var radius = int.Parse(Console.ReadLine());

                    return new Circle(radius);

                default:
                    return null;
            }
        }
    }
}
