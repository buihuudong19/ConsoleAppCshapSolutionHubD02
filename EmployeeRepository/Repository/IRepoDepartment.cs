using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeRepository.Entities;

namespace EmployeeRepository.Repository
{
    public interface IRepoDepartment
    {
        Department[] GetDepartments();
    }
}
