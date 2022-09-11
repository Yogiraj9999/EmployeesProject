using Employee_System.EmployeeData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_System.Controllers
{
    [Route("Employees")]
    public class EmployeesController : Controller
    {
        private IEmployeeData _employeeData;
        public EmployeesController(IEmployeeData employeeData)
        {
            _employeeData = employeeData;
        }

        [HttpGet]
        [Route("GetEmployees")]
        public IActionResult GetEmployees()
        {
            return Ok(_employeeData.GetEmployees());
        }
    }
}
