using System;
namespace ConsoleAppOOP
{
    public class Student
    {
        //1. fields
        private int id;
        private string fullName;

        //2. thuoc tinh
        public int Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }

        public string Address;
        public double Mark;

        //ham
        public void Display()
        {
            Console.WriteLine($"Id = {Id}, Fullname is: {FullName}, " +
                $"Address: {Address} and Mark: {Mark}");  
        }
    }
}
