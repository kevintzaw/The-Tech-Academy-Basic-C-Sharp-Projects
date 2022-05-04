using System;

namespace Method
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            Class1 newObject = new Class1();
            string firstString = Console.ReadLine();
            int x = Convert.ToInt32(firstString);
            try
            {
                Console.WriteLine("Enter another number. It's optional if you don't.");
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
