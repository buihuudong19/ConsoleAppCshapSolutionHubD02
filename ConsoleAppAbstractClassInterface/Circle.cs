using System;

namespace ConsoleAppAbstractClassInterface
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 1.0;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetPerimetter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
