using Employee.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Api.Controllers
{
    [ApiController]
    [Route("api/employee")]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeData _employeeData;

        public EmployeesController(EmployeeData employeeData) => _employeeData = employeeData;

        [HttpGet]
        public ActionResult<IEnumerable<EmployeeViewModel>> GetEmployees()
        {
            return Ok(_employeeData.employeesList);
        }

        [HttpPost]
        public ActionResult PostEmployees([FromBody] EmployeeViewModel emp)
        {
            var employees = (_employeeData.employeesList);

            employees.Add(new EmployeeViewModel { id = emp.id, FirstName = emp.FirstName, LastName = emp.LastName, MobileNumber = emp.MobileNumber, City = emp.City, Country = emp.Country, AddressLine1 = emp.AddressLine1, AddressLine2 = emp.AddressLine2, Email = emp.Email });
            return Ok(employees);
        }

        [HttpPut]
        public IActionResult UpdateEmployee(int empId, EmployeeViewModel employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee object can't be null");
            }
            if (_employeeData.employeesList == null)
            {
                return NotFound("Table doesn't exists");
            }
            var Update = _employeeData.employeesList.Where(e => e.id == empId).FirstOrDefault();
            if (Update == null)
            {
                return NotFound("Employee with this empId doesn't exists");
            }
            _employeeData.employeesList.Remove(Update);
            Update.id = employee.id;
            Update.FirstName = employee.FirstName;
            Update.LastName = employee.LastName;
            Update.MobileNumber = employee.MobileNumber;
            Update.City = employee.City;
            Update.Country = employee.Country;
            Update.AddressLine1 = employee.AddressLine1;
            Update.AddressLine2 = employee.AddressLine2;
            Update.Email = employee.Email;

            _employeeData.employeesList.Add(Update);

            return Ok(_employeeData.employeesList);

        }
        [HttpDelete]
        public ActionResult DeleteEmployee(int empId)
        {
            if (_employeeData.employeesList == null)
            {
                return NotFound("Table doesn't exists");
            }
            var employeeToDelete = _employeeData.employeesList.Where(e => e.id == empId).FirstOrDefault();
            if (employeeToDelete == null)
            {
                return NotFound("Employee with this empId doesn't exists");
            }
            _employeeData.employeesList.Remove(employeeToDelete);
            return Ok(_employeeData.employeesList);
        }


    }
}
