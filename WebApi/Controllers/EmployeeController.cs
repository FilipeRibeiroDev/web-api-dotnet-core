using Microsoft.AspNetCore.Mvc;
using WebApi.Model;
using WebApi.ViewModel;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

        [HttpPost]
        public IActionResult Add(EmployeeViewModel employeeView)
        {
            var employee = new Employee(employeeView.Name, employeeView.Age, null);

            _employeeRepository.Add(employee);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employess = _employeeRepository.Get();

            return Ok(employess);
        }
    }
}
