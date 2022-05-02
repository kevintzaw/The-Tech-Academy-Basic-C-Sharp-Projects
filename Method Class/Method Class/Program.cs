using System;

namespace Method_Class
{
    
    //Create a class
    public class newClass
    {
        public static void twoIntegers(int firstInteger = 3, int secondInteger = 9)
        {
            //math operation on first integer
            int resultInteger = firstInteger + 7;
            //display the second integer on the screen
            Console.WriteLine(secondInteger);
        }

        static void Main(string[] args)
        {
            //instantiate the class
            newClass newInstantiate = new newClass();
            Console.WriteLine(newInstantiate.resultInteger);

            //calling the method in the class
            twoIntegers(int firstInteger = 5, int secondInteger = 11);

        }


    }

    //Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            twoIntegers();
        }
    }
}
