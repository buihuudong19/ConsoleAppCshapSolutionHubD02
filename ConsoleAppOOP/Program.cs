using System;

namespace ConsoleAppOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Id = 1;
            s1.FullName = "Dong";
            s1.Address = "Quan 10";
            s1.Mark = 5.5;

            s1.Display();


        }
    }
}
