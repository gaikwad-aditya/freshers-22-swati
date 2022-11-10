using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject2
{
    class GenericClass
    {
        public void Display<TypeOfValue>(string msg, TypeOfValue value)
        {
            Console.WriteLine("{0}:{1}", msg, value);
        }
    }
}
