using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject2
{
    class StackClass
    {
        public void getval(int val)
        {
            Console.WriteLine(val);
            getval(++val);
        }
        public void execute()
        {
            try
            {
                getval(0);
            }
            catch(StackOverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
