using DbProject.Interfaces;
using DbProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiEntity.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _StudentRepository; 

        public StudentController(IStudentRepository studentRepository)
        {
            _StudentRepository = studentRepository;
        }   
        [HttpGet]
        public ActionResult GetStudents()
        {
            var students = _StudentRepository.GetStudents();
            return Ok(students);
        }

        [HttpGet]
        public ActionResult GetStudentById(int id)
        {
            try
            {
                var student = _StudentRepository.GetStudentById(id);
                return Ok(student);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }


        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            try
            {
                var addedStudent = _StudentRepository.AddStudent(student);
                return Ok(addedStudent);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }

        }

        
    }
}
