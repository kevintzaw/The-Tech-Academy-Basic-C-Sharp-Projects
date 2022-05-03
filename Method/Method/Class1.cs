using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    public class Class1
    {
        public int IntegerMethod(int x, int y = 2)
        {
            int result = x * y;
            return result;
        }
    }
}
