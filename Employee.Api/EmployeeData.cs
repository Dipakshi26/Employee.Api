using Employee.Api.Models;

namespace Employee.Api
{
    public class EmployeeData
    {
        public List<EmployeeViewModel> employeesList { get; set; }

        public EmployeeData()
        {
            employeesList = new List<EmployeeViewModel>()
            {
                 new EmployeeViewModel()
                {
                    id = 1,
                    FirstName = "Dipakshi",
                    LastName = "Saxena",
                    MobileNumber = "8115132666",
                    City = "Lucknow",
                    Country = "India",
                    AddressLine1 = "Aliganj",
                    AddressLine2 = "Aliganj",
                    Email = "dipakshi@gmail.com",
                },
                new EmployeeViewModel()
                {
                    id = 2,
                    FirstName = "Aditya",
                    LastName = "Singh",
                    MobileNumber = "562983234",
                    City = "Lucknow",
                    Country = "India",
                    AddressLine1 = "GomtiNagar",
                    AddressLine2 = "GomtiNagar",
                    Email = "aditya@gmai.com",

                },
                new EmployeeViewModel()
                {

                    id = 3,
                    FirstName = "Ayush",
                    LastName = "Gupta",
                    MobileNumber = "928274923",
                    City = "Lucknow",
                    Country = "India",
                    AddressLine1 = "Bhootnath",
                    AddressLine2 = "Bhootnath",
                    Email = "ayush@gmai.com",

                }
            };
        }
    }
}

