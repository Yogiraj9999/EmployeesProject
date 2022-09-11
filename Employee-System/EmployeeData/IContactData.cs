using Employee_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_System.EmployeeData
{
    public interface IContactData 
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(int ID);

        Employee AddEmployee(Employee employee);

        void DeleteEmployee(Employee employee);

        Employee EditEmployee(Employee employee);

    }
}
