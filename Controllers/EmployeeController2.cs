using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SwaggerUI.Models;

namespace SwaggerUI.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{v:apiVersion}/Employee")]
    [ApiController]
    public class Employee2Controller : ControllerBase
    {
        /// <summary>
        /// Gets the list of all Employees.
        /// </summary>
        /// <returns>The list of Employees.</returns>
        // GET: api/Employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return GetEmployees();
        }

        // GET: api/Employee/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return GetEmployees().Find(e => e.Id == id);
        }

        /// <summary>
        /// Creates an Employee.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Employee
        ///     {        
        ///       "firstName": "Mike",
        ///       "lastName": "Andrew",
        ///       "emailId": "Mike.Andrew@gmail.com"        
        ///     }
        /// </remarks>
        /// <param name="employee"></param>
        /// <returns>A newly created employee</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>          
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [Produces("application/json")]
        public Employee Post([FromBody] Employee employee)
        {
            // Logic to create new Employee
            return new Employee();
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee employee)
        {
            // Logic to update an Employee
        }

        // DELETE: api/Employee/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private List<Employee> GetEmployees()
        {
            return new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                FirstName= "John2",
                LastName = "Smith2",
                EmailId ="John.Smith.2nd@gmail.com"
            },
            new Employee()
            {
                Id = 2,
                FirstName= "Jane2",
                LastName = "Doe2",
                EmailId ="Jane.Doe2@gmail.com"
            }
        };
        }
    }
}
