using ADONetCurd.Models;
using ADONetCurd.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ADONetCurd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class StudentController : ControllerBase
    {
        private readonly StudentRepository _studentRepository;

        public StudentController(IConfiguration configuraion)
        {
            _studentRepository = new StudentRepository(configuraion);
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentRepository.Get());
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            return Ok(_studentRepository.Create(student));
        }

        [HttpPost]
        [Route("createusingsp")]
        public IActionResult PostUsingSP(Student student)
        {
            return Ok(_studentRepository.CreateUsingStoredProcedure(student));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Student student, int id)
        {
            //var inventory = new Inventory() { Name = "Flower", Price = 34.45M, Quantity = 1 };
            return Ok(_studentRepository.Update(student, id));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_studentRepository.Delete(id));
        }
    }
}
