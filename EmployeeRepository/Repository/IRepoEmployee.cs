using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeRepository.Entities;

namespace EmployeeRepository.Repository
{
    public interface IRepoEmployee
    {
        IList<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        void AddEmployee(Employee entity);
        void UpdateEmployee(Employee entity);
        void DeleteEmployee(Employee entity);
        void DeleteEmployee(int id);
    }
}
