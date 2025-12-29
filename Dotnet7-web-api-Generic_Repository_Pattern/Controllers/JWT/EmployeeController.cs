using GenericRepository_JWT.JWT.Interface;
using GenericRepository_JWT.JWT.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GenericRepository_JWT.Controllers.JWT
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Owner,Co-Owner")]
    public class EmployeeController : ControllerBase
    {
        // GET: api/<EmployeeController>

        private readonly IEmployeeService employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
           

        }
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            var aa = HttpContext.User.Claims.ToList();
            return employeeService.GetAll();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            var employee = employeeService.GetById(id);
            return employee;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public Employee Post([FromBody] Employee employeeDetails)
        {
            var employee = employeeService.Add(employeeDetails);
            return employee;
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public Employee Put(int id, [FromBody] Employee employeeDetails)
        {
            var employee = employeeService.Update(employeeDetails, id);
            return employee;
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public Employee Delete(int id)
        {
            var employee = employeeService.Delete(id);
            return employee;
        }
    }
}
