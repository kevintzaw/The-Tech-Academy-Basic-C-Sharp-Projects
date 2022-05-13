using System;
using System.Collections.Generic;
using System.Linq;

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

            List<person> joeList1 = new List<person>();
            foreach(person employee in employeeNames)
                {
                if(employee.firstName == "Joe") {
                    joeList1.Add(employee);
                }
                
                }
            foreach (person employee in joeList1)
            {
                Console.WriteLine("{0} {1} {2}", employee.firstName, employee.lastName, employee.employeeId);
            }

            //lambda expression with Joe
            List<person> joeList2 = employeeNames.Where(x => x.firstName == "Joe").ToList();

            foreach (person employee in joeList2)
            {
                Console.WriteLine("{0} {1} {2}", employee.firstName, employee.lastName, employee.employeeId);
            }

            //lambda expression with Ids over 5
            List<person> idOver5 = employeeNames.Where(x => x.employeeId > 5).ToList();

            foreach (person employee in idOver5)
            {
                Console.WriteLine("{0} {1} {2}", employee.firstName, employee.lastName, employee.employeeId);
            }



            Console.ReadLine();
        }
    }
}
