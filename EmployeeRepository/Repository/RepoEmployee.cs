
using System;
using EmployeeRepository.Entities;
using System.Collections.Generic;


namespace EmployeeRepository.Repository
{
    public class RepoEmployee : IRepoEmployee
    {
        private static List<Employee> _employees = new List<Employee>() {
           new Employee(1,"Nguyen Van Toan",new DateTime(1990,3,2),10000000,true,1),
           new Employee(2,"Nguyen Thi Thu Ha",new DateTime(1991,4,2),150000000,false,1),
           new Employee(3,"Nguyen Dang Toan",new DateTime(1992,6,2),12000000,true,2),
           new Employee(4,"Thanh Dai Gia",new DateTime(1993,5,2),10200000,true,2),
        };
        public void AddEmployee(Employee entity)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEmployee(Employee entity)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Employee> GetAllEmployees() => _employees;


        public Employee GetEmployeeById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateEmployee(Employee entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
