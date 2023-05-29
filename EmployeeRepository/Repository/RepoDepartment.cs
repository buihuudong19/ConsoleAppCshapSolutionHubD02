using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRepository.Repository
{
    public class RepoDepartment : IRepoDepartment
    {
        //gia su ta khoi tao mot list cac phong ban
        Department[] _departments = { 
            new Department(1,"P. Công nghệ thông tin"),
            new Department(2,"P. Kế toán"),
            new Department(3,"P. Marketing"),
            new Department(4,"P. Tổ chức nhân sự"),
            new Department(5,"P. Kinh doanh")

        };
        public Department[] GetDepartments() => _departments;

    }
}
