using System;

namespace PracticeProject1
{
    class validate
    {
        public void isValidate()
        {
            string email1 = "swatipandit@gmail.com";

            if(email1.Contains('@')==true && email1.EndsWith(".com")==true)
            {
                Console.WriteLine(email1 + " is validated");
            }
            else
            {
                Console.WriteLine(email1 + " is not validated");
            }
        }
    }
}
