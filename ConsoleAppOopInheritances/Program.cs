using System;

namespace ConsoleAppOopInheritances
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Tạo object
            Circle c = new Circle(150, "Blue", new DateTime(2023, 05, 22));
        
            Console.WriteLine(c);
        }
    }
}
