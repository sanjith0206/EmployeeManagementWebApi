using EmployeeManagementAPI.DTO;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagementAPI.Service;


namespace EmployeeManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService service;

        public EmployeeController(EmployeeService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployee()
        {
            return Ok(await service.GetEmployee());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdEmployee(int id)
        {
            var Result = await service.GetByIdEmployee(id);
            if (Result == null)
                return NotFound("!! There is no employee in that ID or The Employee is not active !!");

            return Ok(Result);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(CreateEmployeeDTO Employee)
        {
            return Ok(await service.AddEmployee(Employee));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, UpdateEmployeeDTO Employee)
        {
            return Ok(await service.updateEmployee(id, Employee));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            return Ok(await service.DeleteEmployee(id));
        }
    }
}
