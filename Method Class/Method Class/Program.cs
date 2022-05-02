using System;

namespace Method_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //defining two int variables
            int num1 = 3;
            int num2 = 5;

            //instantiating an object of the class
            newClass obj1 = newClass();

            //calling the "twoIntegers" method through the "obj1" object, passing in "num1" and "num2"
            obj1.twoIntegers(num1, num2);

            //calling the "twoIntegers" method again, explicitly passing in values for the parameters
            obj1.twoIntegers(firstInteger: 6, secondInteger: 8);

            Console.ReadLine();
        }
    }
}
