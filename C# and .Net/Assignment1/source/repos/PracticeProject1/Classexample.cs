using System;

namespace PracticeProject1
{
    class Bank
    {
        public string bank_name = "SBI";
        public string city = "Nagpur";

        public int bankid;
        public int cityid;

        public Bank()
        {
            bankid = 101;
            cityid = 440;
        }

        public void Display()
        {
            Console.WriteLine("Bank NAme = ",bank_name);
            Console.WriteLine("City Name =", city);
        }
    }

    class Account : Bank
    {
        public int[] AccNo = { 101, 102, 103, 104, 105 };
        public int[] BalCurrent = { 200, 300, 400, 500, 600 };

        public void Savings()
        {
            
            Console.WriteLine("Savings Account");

        }
        public void Current()
        {
            Console.WriteLine("Current Account");
            for (int i = 0; i < AccNo.Length; i++)
            {
                Console.WriteLine("Account Number {0} have {1} balance", AccNo[i], BalCurrent[i]);
            }
        }
    }

    class Customer : Account
    {
        public int[] CustId = { 1, 2, 3, 4, 5 };

        public int Interest(int P, int R, int T)
        {
            return (P * R * T) / 100;
        }

        public void Display()
        {
            for (int i = 0; i < AccNo.Length; i++)
            {
                Console.WriteLine("Customer Id {0} have Accont Number {1} :", CustId[i], AccNo[i]);
            }
        }

        public void Details(String Firstname, String Lastname)
        {
            Console.WriteLine("First name {0} Last Name {1}", Firstname, Lastname);
        }
        public void Details(String Firstname, String Lastname, String city)
        {
            Console.WriteLine("First name= {0} Last Name= {1} City= {2}", Firstname, Lastname, city);
        }
    }
}
