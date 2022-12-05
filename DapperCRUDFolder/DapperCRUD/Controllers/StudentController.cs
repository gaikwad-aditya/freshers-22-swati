using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace DapperCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IConfiguration _config;
        public StudentController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            IEnumerable<Student> students = await SelectAllStudents(connection);
            return Ok(students);
        }

        [HttpGet("{studentId}")]
        public async Task<ActionResult<List<Student>>> GetStudent(int studentId)
        {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            var student = await connection.QueryFirstAsync<Student>("select * from Student where id= @Id",
                new { Id = studentId });
            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<List<Student>>> CreateStudent(Student stu)
        {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            await connection.ExecuteAsync("insert into Student (id, Name, City) values (@Id, @Name, @City)", stu);
            return Ok(await SelectAllStudents(connection));
        }

        [HttpPut]
        public async Task<ActionResult<List<Student>>> UpdateStudent(Student stu)
        {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            await connection.ExecuteAsync("update Student set Name=@Name, City=@City where id=@Id", stu);
            return Ok(await SelectAllStudents(connection));
        }

        [HttpDelete("{studentId}")]
        public async Task<ActionResult<List<Student>>> DeleteStudent(int studentId)
        {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            await connection.ExecuteAsync("delete from Student where id = @Id", new {Id = studentId});
            return Ok(await SelectAllStudents(connection));
        }

        private static async Task<IEnumerable<Student>> SelectAllStudents(SqlConnection connection)
        {
            return await connection.QueryAsync<Student>("select * from Student");
        }
    }
}
