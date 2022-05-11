using System;
using System.Collections.Generic;
using System.Text;

namespace Operatores
{
    class Employee
    {
       
        public void employeeMethod1(int employee1, int employee2)
        {
            Console.WriteLine(employee1 == employee2);
        }

        public void employeeMethod2(int employee1, int employee2)
        {
            Console.WriteLine(employee1 != employee2);
        }
    }
}
