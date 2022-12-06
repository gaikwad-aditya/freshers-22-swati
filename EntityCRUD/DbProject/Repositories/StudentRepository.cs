using DbProject.Interfaces;
using DbProject.DatabaseContext;
using DbProject.Models;

namespace DbProject.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SqlServerContext _SqlServerContext;

        public StudentRepository(SqlServerContext sqlServerContext)
        {
            _SqlServerContext = sqlServerContext;
        }

        public List<Student> GetStudents()
        {
            var lstStudents = _SqlServerContext.Student.ToList();
            return lstStudents;
        }
        

        public Student GetStudentById(int id)
        {
            var student = _SqlServerContext.Student.FirstOrDefault(x => x.Id == id);
            return student;

        }

        public Student AddStudent(Student student)
        {
            _SqlServerContext.Student.Add(student);
            _SqlServerContext.SaveChanges();
            return student;
        }
    }
}
