using System;

namespace Calling_Methods
{
    
    class Program
    {
        //addition method
        static void additionMethod(int userValue)
        {
            Console.WriteLine(userValue + 7);
        }

        //subtraction method
        static void subtractionMethod(int userValue)
        {
            Console.Write(userValue - 7);
        }

        //multiply method
        static void multiplyMethod(int userValue)
        {
            Console.Write(userValue * 7);

        }

        static void Main(string[] args)
        {
            //user input
            Console.WriteLine("What number do you want to use for this operation?");
            string userInput = Console.ReadLine();
            int userValue = Convert.ToInt32(userInput);

            //calling methods and displayed integers
            additionMethod(userValue);
            subtractionMethod(userValue);
            multiplyMethod(userValue);



        }
    }
}
