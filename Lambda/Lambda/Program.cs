using System;
using System.Collections.Generic;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //List to store names of employees
            List<person> employeeNames = new List<person>();

            employeeNames.Add(new person() { firstName = "Joe", lastName = "Smith", employeeId = 1 });
            employeeNames.Add(new person() { firstName = "James", lastName = "Smith", employeeId = 2 });
            employeeNames.Add(new person() { firstName = "Kevin", lastName = "Smith", employeeId = 3 });
            employeeNames.Add(new person() { firstName = "Joe", lastName = "Clinton", employeeId = 4 });
            employeeNames.Add(new person() { firstName = "Jennifer", lastName = "Abott", employeeId = 5 });
            employeeNames.Add(new person() { firstName = "Sam", lastName = "Andy", employeeId = 6 });
            employeeNames.Add(new person() { firstName = "Ryan", lastName = "Cash", employeeId = 7 });
            employeeNames.Add(new person() { firstName = "John", lastName = "Cena", employeeId = 8 });
            employeeNames.Add(new person() { firstName = "Andrea", lastName = "Smith", employeeId = 9 });
            employeeNames.Add(new person() { firstName = "Ava", lastName = "Hamlet", employeeId = 10 });


            //foreach loop to display the namers of Joe
            Console.Write("Names of Joe: ");
            foreach(var value in employeeNames)
                {
                Console.Write("{0} ", employeeNames);
                }
            Console.WriteLine();

            //lambda expression
            var idWithOver5 = employeeNames.Select(employeeId => employeeId > 5);

            //foreach loop to display values
            Console.Write("Ids with over 5: ");
            foreach (var value in idWithOver5)
            {
                Console.Write(idWithOver5);
            }
            Console.WriteLine();
        }
    }
}
