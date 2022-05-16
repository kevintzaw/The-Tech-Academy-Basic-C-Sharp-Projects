using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    public class Employee
    {
        public int employeeNumber;
        //variable using the keyword "var"
        public string var;

        public Employee(){
            Console.WriteLine("Reserving new record for the upcoming employee");
        }
        public Employee(string var){
            this.var = var;
            Console.WriteLine("Creating new record for the upcoming employee, with variable string");
        }
        public Employee( string var, int employeeNumber){
            this.var = var;
            this.employeeNumber = employeeNumber;
            Console.WriteLine("Creating new record for the upcoming employee with variable string and employeeNumber.");
        }
    }
}
