using System;
using System.Collections.Generic;
using System.Text;

namespace Class1
{
    public class mathOperation
    {
        //dividing method
        public void oneInteger(int userInteger)
        {
            //math operation on integer
            int resultInteger = userInteger / 2;
            //display the resulting integer on the screen
            Console.WriteLine(resultInteger);
        }

        //overloading a method
        public void oneInteger(int oneInteger, int twoInteger)
        {
            int resultInteger = oneInteger + twoInteger;
            Console.WriteLine(resultInteger);
        }
    }
}
