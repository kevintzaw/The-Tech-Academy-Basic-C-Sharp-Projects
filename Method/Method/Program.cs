using System;

namespace Method
{
    //class
    public class mathOperation
    {
        public static void integerMethod()
        {
            int firstNum;
            int secondNum;
        }

    }
    
    //Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers. The second number is optional");
            string firstString = Console.ReadLine();
            int firstNum = Convert.ToInt32(firstString);
            string secondString = Console.ReadLine();
            int secondNum = Convert.ToInt32(secondString);
            //adding two of the numbers
            Console.WriteLine(firstNum + secondNum);

        }
    }
}
