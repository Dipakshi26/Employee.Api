﻿namespace Employee.Api.Models
{
    public class EmployeeViewModel
    {
        public int id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MobileNumber { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }

        public string? Email { get; set; }

    }
}
