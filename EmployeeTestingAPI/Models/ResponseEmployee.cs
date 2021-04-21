using EmployeeTestingAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeTestingAPI.Models
{
    public class ResponseEmployee
    {
        public ResponseEmployee(Employee employee)
        {
            ID_Employee = employee.ID_Employee;
            Surname = employee.Surname;
            Name = employee.Name;
            Middlename = employee.Middlename;
            ID_Position = employee.ID_Position;
            Position = employee.Position.Name;
        }

        public int ID_Employee { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public int ID_Position { get; set; }
        public string Position { get; set; }
    }
}