using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.ModelBinding;
using EmployeeTestingAPI.Models;
using EmployeeTestingAPI.Models.Entities;

namespace EmployeeTestingAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        private EmployeeTesting db = new EmployeeTesting();

        // GET: api/Employees
        [ResponseType(typeof(List<ResponseEmployee>))]
        public IHttpActionResult GetEmployees()
        {
            return Ok(db.Employee.ToList().ConvertAll(p => new ResponseEmployee(p)));
        }

        [Route("api/Emp")]
        public IHttpActionResult GetEmployees2()
        {
            return Ok(db.Employee.ToList().LastOrDefault());
        }

        // GET: api/Positions
        [Route("api/Positions")]
        public IHttpActionResult GetPositions()
        {
            return Ok(db.Position.ToList());
        }

        [ResponseType(typeof(ResponseEmployee))]
        public IHttpActionResult PostEmployee(Employee employee)
        {
            if (string.IsNullOrWhiteSpace(employee.Surname) || employee.Surname.Length > 80)
                ModelState.AddModelError("Фамилия", "Фамилия сотрудника обязательна к заполнению и не должно превышать 80 символов");

            if (string.IsNullOrWhiteSpace(employee.Name) || employee.Name.Length > 80)
                ModelState.AddModelError("Имя", "Имя сотрудника обязательно к заполнению и не должно превышать 80 символов");

            if (string.IsNullOrWhiteSpace(employee.Middlename) || employee.Middlename.Length > 80)
                ModelState.AddModelError("Отчество", "Отчество сотрудника обязательно к заполнению и не должно превышать 80 символов");

            if (employee.ID_Position == 0 || db.Position.ToList().Find(p => p.ID_Position == employee.ID_Position) == null)
                ModelState.AddModelError("Должность", "Должность сотрудника обязательна к заполнению");

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Employee.Add(employee);
            db.SaveChanges();

            return CreatedAtRoute("DefaultAPI", new { id = employee.ID_Employee }, employee);
        }
    }
}
