using System;

namespace ConsoleAppAbstractClassInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AbsShape s = new Rectangle(150,50);
            s.Color = "Green";

            Console.WriteLine(s);
        }
    }
}
