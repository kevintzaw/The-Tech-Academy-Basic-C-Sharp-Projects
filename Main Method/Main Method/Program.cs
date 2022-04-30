using System;

namespace Main_Method
{

    //New class
    class operationClass
    {
        //Method for integer with addition
        static void additionMethod()
        {
            int basicInteger = 7;
            int resultInteger = basicInteger + 9;
            Console.WriteLine(resultInteger);
        }
        //Method for decimal with addition
        static void decimalAdditionMethod()
        {
            double a = 1.5;
            double b = 3.6;
            Console.WriteLine(a + b);
        }
        //Method for string convert to integer for addition
        static void stringAdditionMethod()
        {
            string stringNumber = "7";
            int stringInteger = Convert.ToInt32(stringNumber);
            int resultString = (stringInteger + 7);
            Console.WriteLine(resultString);
        }

        static void Main(string[] args)
        {
            additionMethod();

        }

    }

    //Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }
}
