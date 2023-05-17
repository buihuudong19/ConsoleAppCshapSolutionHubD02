using System;
namespace ConsoleAppOOP
{
    public class Student
    {
        //1. fields/data
        private int id;
        private string fullName;

        //2. thuoc tinh
        public int Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }

        public string Address;
        public double Mark;

        //3.constructor
        public Student()
        {
            id = 1;
            Mark = .5;
        }

        public Student(int id, string fullName, string address, double mark)
        {
            this.id = id;
            this.fullName = fullName;
            Address = address;
            Mark = mark;
        }


        //ham
        public void Display()
        {
            Console.WriteLine(calcInfor());  
        }
        //expression bodied/lambda/arrow 
        private string calcInfor() => $"Id = {this.id}, Fullname is: {FullName}, " + $"Address: {Address} and Mark: {Mark}";

        public override string ToString() => calcInfor();

    }
}
