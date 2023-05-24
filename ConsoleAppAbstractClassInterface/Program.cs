using System;

namespace ConsoleAppAbstractClassInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AbsShape s = new Rectangle(150,50);
            s.Color = "Green";

            Circle c = new Circle(123.7);
            IShape c1 = new Circle(123.7);
            
            Console.WriteLine(c);
        }
    }
}
