using System;

namespace Calling_Methods
{
    
    class Program
    {

        static void Main(string[] args)
        {
            //instantiate class
            operationsClass passthroughValue = new operationsClass();
            
            //user input
            Console.WriteLine("What number do you want to use for this operation?");
            string userInput = Console.ReadLine();
            int userValue = Convert.ToInt32(userInput);

            //calling methods and displayed integers
            Console.WriteLine(passthroughValue.additionMethod(userValue));
            Console.WriteLine(passthroughValue.subtractionMethod(userValue));
            Console.WriteLine(passthroughValue.multiplyMethod(userValue));

     

        }
    }
}
