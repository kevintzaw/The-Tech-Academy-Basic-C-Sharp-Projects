using System;

namespace Operatores
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newObj1 = new Employee();
            newObj1.employeeName1 = "Kevin";
            newObj1.id = 7;
            Employee newObj2 = new Employee();
            newObj2.employeeName2 = "Andy";
            newObj2.id = 5;

            if (newObj1.id == newObj2.id)
            {
                Console.WriteLine("They are even");
            }
            else
            {
                Console.WriteLine("They are not even");
            }
                
        }
    }
}
