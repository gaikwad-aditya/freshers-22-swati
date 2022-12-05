using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject2
{
    class Employee
    {
        int emp_id;
        string emp_name;
        string emp_department;
        int emp_salary;

        public void ShowSalary()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{emp_id=101,emp_name= "Swati", emp_department="Testing", emp_salary=43000},
                new Employee{emp_id=102,emp_name= "Pranay", emp_department="Development", emp_salary=50000},
                new Employee{emp_id=103,emp_name= "Akash", emp_department="Testing", emp_salary=35000},
                new Employee{emp_id=104,emp_name= "Rutuja", emp_department="Admin", emp_salary=45000},
                new Employee{emp_id=105,emp_name= "Smita", emp_department="Testing", emp_salary=50000},
            };

            var result = employees.Where(emp => emp.emp_department == "Testing").OrderByDescending(sal => sal.emp_salary);

            foreach (Employee emp in result)
            {
                Console.WriteLine(emp.emp_id + " " +emp.emp_name + " " +emp.emp_salary + " " +emp.emp_department);
            }
        }
    }
}
