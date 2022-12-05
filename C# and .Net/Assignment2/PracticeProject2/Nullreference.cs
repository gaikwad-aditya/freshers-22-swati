using System;

namespace PracticeProject2
{
    class Nullreference
    {
        public void NullException()
        {
            string val = null;
            try
            {
                Console.WriteLine(val.Substring(2));
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
           
            Console.Read();
        }
    }
}

