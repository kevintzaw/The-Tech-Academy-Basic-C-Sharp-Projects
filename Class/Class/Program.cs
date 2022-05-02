using System;

namespace Class
{
    public class Program
    {
        //void method that outputs an integer
        public static void divInteger(int initialInteger)
        {
            int resultInteger = initialInteger / 2;
            Console.WriteLine(resultInteger);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //instantiate class
            Program myObj = new Program();

            //ask the user for a number
            Console.WriteLine("Input a Number");
            string userValue = Console.ReadLine();
            int userNumber = Convert.ToInt32(userValue);
            divInteger(userNumber);

        }
    }
}
