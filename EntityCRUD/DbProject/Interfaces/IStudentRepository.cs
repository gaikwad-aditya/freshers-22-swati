using DbProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();

        Student GetStudentById(int id);

        Student AddStudent(Student student);
    }
}
