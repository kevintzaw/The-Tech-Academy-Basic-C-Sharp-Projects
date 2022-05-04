using System;

namespace Method
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers. The second number is optional");
            Class1 newObject = new Class1();
            string firstString = Console.ReadLine();
            int x = Convert.ToInt32(firstString);
            try
            {
                string secondString = Console.ReadLine();
                int y = Convert.ToInt32(secondString);
                Console.WriteLine(newObject.IntegerMethod(x, y));
            }
            catch
            {
                Console.WriteLine(newObject.IntegerMethod(x));
            }
           
                
        }
    }
}
