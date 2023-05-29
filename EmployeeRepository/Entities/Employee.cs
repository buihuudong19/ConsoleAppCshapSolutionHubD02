using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRepository.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public double Salary { get; set; }
        public bool Sex { get; set; } = true;// true: name else false
        public Department Department {get;set;}

        public Employee(int id, string name, DateTime dob, double salary, bool sex, Department department)
        {
            Id = id;
            Name = name;
            Dob = dob;
            Salary = salary;
            Sex = sex;
            Department = department;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Employee Name: {Name}" +
                $" Dob: {Dob}, Salary: {Salary}, Sex: {Sex} and Department: {Department}";
        }
    }
}
