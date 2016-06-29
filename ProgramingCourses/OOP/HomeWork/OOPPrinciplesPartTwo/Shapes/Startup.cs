namespace Shapes
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var figureList = new List<Shape>{

                new Square(5),
                new Triangle(3,3),
                new Rectangle(4,4),
                new Square(5.2),
                new Triangle(3.4,3.4),
                new Rectangle(4.5,4.5)
            };

            foreach (var figure in figureList)
            {
                Console.WriteLine(figure.CalculateSurface());
            }
        }
    }
}
