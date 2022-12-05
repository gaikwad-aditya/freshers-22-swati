using System;

namespace ConsoleAppCore
{
    internal class Program
    {
        int a = 10;
        int b = 20;

        public int addnum()
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int c;
            Program obj = new Program();

            c = obj.addnum();
            Console.WriteLine("Addition is {0}", c);
            Console.ReadLine();
        }
    }
}

