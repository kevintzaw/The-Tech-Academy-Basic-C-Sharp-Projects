using System;
using System.Collections.Generic;
using System.Text;

namespace Operatores
{
    class Employee
    {
        public int id;
        public string employeeName1;
        public string employeeName2;
       
        public static bool operator== (Employee obj1, Employee obj2)
        {
            return (obj1.id == obj2.id);
        }

        public static bool operator!= (Employee obj1, Employee obj2)
        {
            return (obj1.id != obj2.id);   
        }
    }
}
