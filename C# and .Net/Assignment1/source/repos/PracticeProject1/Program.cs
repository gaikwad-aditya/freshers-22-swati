using System;

namespace PracticeProject1
{
    class Test
    {
        public static void Main(string[] args)
        {
            
            //create string
            string str1 = "C# Programming";
            string str2 = "C# Programming";
            string str3 = "Emtec";
            string str4 = "Technologies";

            // compare str1 and str2
            Boolean result1 = str1.Equals(str2);
            Console.WriteLine("string str1 and str2 are equal: " + result1);

            //compare str1 and str3
            Boolean result2 = str1.Equals(str3);
            Console.WriteLine("string str1 and str3 are equal: " + result2);

            //strings to concat
            Console.WriteLine("string str3: " + str3);
            Console.WriteLine("string str4: " + str4);

            // join two strings
            string joinedString = string.Concat(str3, str4);
            Console.WriteLine("Joined string: " + joinedString);

            //Substring
            Console.WriteLine("Sub String1: " + str1.Substring(2));

            //Reverse a string
            char[] charArray = joinedString.ToCharArray();

            string reversedString = String.Empty;
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reversedString += charArray[i];
            }
            Console.WriteLine(reversedString);

            //Email validation

            validate obj = new validate();
            obj.isValidate();

            enum_assign obje = new enum_assign();
            obje.displayenum();


            //Class Example
            Console.WriteLine("\n Class Example");
            int P = 30000, R = 6, T = 1;
            int SI;
            String Firstname = "Swati";
            String Lastname = "Pandit";
            String City = "Nagpur";

            Customer cust = new Customer();
            cust.Display();
            Console.WriteLine(cust.bankid);
            Console.WriteLine(cust.cityid);
            cust.Current();
            cust.Details(Firstname, Lastname,City);
            cust.Details(Firstname, Lastname);
            SI = cust.Interest(P, R, T);
            Console.WriteLine("Simple Interest = {0}", SI);


            Console.ReadLine();
        }
    }
}