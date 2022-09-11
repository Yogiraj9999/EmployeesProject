using Employee_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_System.EmployeeData
{
    public class MockStudentData : IStudentData
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                ID=Guid.NewGuid(),
                Name = "Employee One"
            },
            new Employee()
            {
                ID=Guid.NewGuid(),
                Name = "Employee Two"
            }
        };
        public Employee AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee EditEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            return employees;
            throw new NotImplementedException();
        }
    }
}
