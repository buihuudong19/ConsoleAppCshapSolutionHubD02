using System;

namespace ConsoleAppOopInheritances
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Tạo object: polymophisms
            Shape c1 = new Circle(150, "Blue", new DateTime(2023, 05, 22));
            Shape r1 = new Rectangle(154.55, 100);
            Circle c2 = new Circle(160, "White", new DateTime(2023, 05, 22));

            Display(c2);
            Display(c1);
            Display(r1);
            Console.ReadLine();
        }

        public static void Display(Shape s)
        {
            Console.WriteLine(s);
        }
    }
}
