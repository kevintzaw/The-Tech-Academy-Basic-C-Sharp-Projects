using System;

namespace Class
{
    public class Program
    { 

        static void Main(string[] args)
        {
            //instantiating a class
            MathOperation obj1 = new MathOperation();

            //ask the user for a number
            Console.WriteLine("Input a Number");
            string userValue = Console.ReadLine();
            int userNumber = Convert.ToInt32(userValue);

            //calling the method to the user number
            obj1.oneInteger(userNumber);

            //creating a method with parameters
            int outputVariable = 0;
            obj1.oneInteger(out outputVariable);
            Console.WriteLine(outputVariable);
            //Calling a method from static class
            StaticClass.staticMethod();
            Console.ReadLine();
            

        }
    }
}
