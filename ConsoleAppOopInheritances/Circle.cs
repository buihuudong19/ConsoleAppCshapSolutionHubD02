using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOopInheritances
{
    public class Circle:Shape
    {
        public int Radius { get; set; }

        public Circle()
        {
            Radius = 1;
        }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public Circle(int radius,string color, DateTime dateCreate):base(color,dateCreate)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        //chu vi
        public double GetPerimetter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return $"The circle has radius: {Radius}, Area: {GetArea()}, Perimetter: {GetPerimetter()}" +
                $", {base.ToString()}";
        }
    }
}
