﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Method
{
    //New class
    class operationClass
    {
        //Method for integer with addition
        public int additionMethod(int x)
        {
            int result = x + 5;
            return result;
        }
        //Method for decimal with addition
        public int decimalAdditionMethod(decimal x)
        {
            int result = Convert.ToInt32(x);
            result = result * 2;
            return result;
        }
        //Method for string convert to integer for addition
        public int stringAdditionMethod(string x)
        {
            int result = Convert.ToInt32(x);
            return result + 5;
        }
    }
}
