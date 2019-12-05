using LB.Chinook.WebAPI.WebApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LB.Chinook.WebAPI.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [HttpGet]
        [Route("employees")]
        public IActionResult GetEmployess()
        {
            try
            {
                var messages = employeeRepository.GetEmployees();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}