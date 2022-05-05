using Class1;
using System;

namespace Class
{
    public class Program
    { 

        static void Main(string[] args)
        {
            //instantiating a class
            Class1.mathOperation obj1 = new mathOperation();

            //ask the user for a number
            Console.WriteLine("Input a Number");
            string userValue = Console.ReadLine();
            int userNumber = Convert.ToInt32(userValue);

            //calling the method to the user number
            obj1.mathOperation(userNumber);

            //creating a method with parameters
            int outputVariable;
            mathOperation(outputVariable);
            mathOperation(out int outputVariable);
            

        }
    }
}
