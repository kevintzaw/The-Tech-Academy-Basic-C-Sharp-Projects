using System;

namespace Calling_Methods
{
    
    class Program
    {

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
