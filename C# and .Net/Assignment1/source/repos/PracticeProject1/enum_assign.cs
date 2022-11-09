using System;

namespace PracticeProject1
{
    
    class enum_assign
    {
        enum countries
        {
            INDIA,
            AUSTRALIA,
            USA,
            JAPAN,
            FRANCE,
            ENGLAND
        }
        public void displayenum()
        {
            Console.WriteLine(countries.INDIA);
            Console.WriteLine(countries.AUSTRALIA);
            Console.WriteLine(countries.USA);
            Console.WriteLine(countries.JAPAN);
            Console.WriteLine(countries.FRANCE);
            Console.WriteLine(countries.ENGLAND);
        }
    }
}
