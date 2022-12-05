using System;
using System.Text.RegularExpressions;

namespace PracticeProject2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("\n--Email verification using Regex--");
            string email = "swati@abc.com";
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",RegexOptions.CultureInvariant | RegexOptions.Singleline);
            Console.WriteLine($"The email is {email}");
            bool isValidEmail = regex.IsMatch(email);
            if (!isValidEmail)
            {
                Console.WriteLine($"The email is invalid");
            }
            else
            {
                Console.WriteLine($"The email is valid");
            }

            Console.WriteLine("\n--NullReference exception--");
            Nullreference obj2 = new Nullreference();
            obj2.NullException();

            Console.WriteLine("\n--Divide by zero exception--");
            DivideClass obj1 = new DivideClass();
            obj1.Dividebyzero();

            //Console.WriteLine("\n--StackOverFlow exception--");
            //StackClass obj4 = new StackClass();
            //obj4.execute();

            Console.WriteLine("\n--Select clause LINQ--");
            Student obj3 = new Student();
            obj3.linqfunc();

            //Reading a file
            Console.WriteLine("\n--Reading a text file--");
            string text = System.IO.File.ReadAllText(@"C:\Users\Swati.Pandit\Desktop\C# Assignments  II.txt");
            System.Console.WriteLine("Contents of the file are {0}", text);

            Console.WriteLine("\n--Employee Salary--");
            Employee emp = new Employee();
            emp.ShowSalary();

            Console.WriteLine("\n--Generic class and method--");
            GenericClass p = new GenericClass();
            // calling Generics method
            p.Display<int>("Integer", 122);
            p.Display<char>("Character", 'H');
            p.Display<double>("Decimal", 255.67);

            Console.ReadLine();
        }
    }
}