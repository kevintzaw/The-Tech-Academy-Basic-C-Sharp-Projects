using System;

namespace Main_Method
{


    //Main Program
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating class
            operationClass passingthroughValue = new operationClass();

            //user input
            Console.WriteLine("What string do you want to use?");
            string userString = Console.ReadLine();
            Console.WriteLine("What number (no decimal) do you want to use?");
            string userNumber = Console.ReadLine();
            int userValue = Convert.ToInt32(userNumber);
            Console.WriteLine("What decimal number do you want to use?");
            string userDecimal = Console.ReadLine();
            decimal decimalValue = Convert.ToDecimal(userDecimal);

            //calling methods and displayed integers
            Console.WriteLine(passingthroughValue.stringAdditionMethod(userString));
            Console.WriteLine(passingthroughValue.decimalAdditionMethod(decimalValue));
            Console.WriteLine(passingthroughValue.additionMethod(userValue));

        }
    }
}
