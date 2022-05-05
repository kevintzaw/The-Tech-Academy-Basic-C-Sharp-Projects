using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public class MathOperation
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
        public void oneInteger(out int oneInteger)
        {
            oneInteger = 10;
        }
    }
}
