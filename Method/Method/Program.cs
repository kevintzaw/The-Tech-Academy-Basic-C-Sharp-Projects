using System;

namespace Method
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers. The second number is optional");
            string firstString = Console.ReadLine();
            int x = Convert.ToInt32(firstString);
            string secondString = Console.ReadLine();
            int y = Convert.ToInt32(secondString);
            //multiplying both numbers
            if (y != null)
            {
                IntegerMethod();
            }
            else
            {
                Console.WriteLine("Did not work");
            }
        }
    }
}
