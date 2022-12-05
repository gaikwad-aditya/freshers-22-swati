// C# program to print the list of students
// details using select clause

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject2
{
    class Student
    {
        int stu_id;
        string stu_dept;
        string stu_name;
        int stu_semester;

        public string reString()
        {
            return stu_id + " " + stu_name + " " +
                stu_dept + " " + stu_semester;
        }

        // Driver code
        public void linqfunc()
        {

            // Declare a list variable
            List<Student> stu = new List<Student>()
    {
		
		    // Create 3 Student details
		    new Student{ stu_id = 101, stu_name = "bobby",
                        stu_dept = "CSE", stu_semester = 2 },
            new Student{ stu_id = 102, stu_name = "sravan",
                        stu_dept = "ECE", stu_semester = 1 },
            new Student{ stu_id = 103, stu_name = "deepu",
                        stu_dept = "EEE", stu_semester = 4},
    };

            // Iterate the Employee
            // using select function
            IEnumerable<Student> Query = from student in stu select student;

            // Display student details
            Console.WriteLine("ID Name Department Semester");
            Console.WriteLine("+++++++++++++++++++++++++++");
            foreach (Student e in Query)
            {

                // Call the to string method
                Console.WriteLine(e.reString());
            }
        }
    }
}

