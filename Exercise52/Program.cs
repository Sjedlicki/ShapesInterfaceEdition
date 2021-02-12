using System;
using System.Linq;

namespace Exercise52
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveShape(new ShapeRepository());
        }

        private static void Menu()
        {
            Console.Write($"Enter a new shape.  Square (1), Triangle (2), Circle(3), Quit(q): ");
        }

        private static void SaveShape(IShapeRepository repository)
        {
            bool tryAgain;
            do
            {
                var input = string.Empty;

                while (input != "q")
                {
                    Menu();

                    input = Console.ReadLine();

                    var shape = ShapeFactory.GetShape(input);

                    if (shape == null)
                    {
                        DisplayResults(repository);
                    }
                    else
                    {
                        repository.Save(shape);
                    }
                }


                Console.Write("Would you like to continue (y/n)? ");
                tryAgain = Console.ReadLine().Trim().Equals("y", StringComparison.OrdinalIgnoreCase);
            } while (tryAgain);
        }

        private static void DisplayResults(IShapeRepository repository)
        {
            var shapes = repository.GetAll();

            var averageArea = Math.Round(shapes.Select(x => x.Area()).Average(), 2);
            var averagePerimeter = Math.Round(shapes.Select(x => x.Perimeter()).Average(), 2);

            Console.WriteLine($"Average Area: {averageArea}");
            Console.WriteLine($"Average Perimeter: {averagePerimeter}");
        }
    }
}
