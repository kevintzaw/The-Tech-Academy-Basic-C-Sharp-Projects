using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    public class Employee
    {
        public int employeeNumber { get; set; }
        public string employeeName { get; set; }
        
        public Employee(){
            Console.WriteLine("Reserving new record for the upcoming employee");
        }

        //constructor that takes in one string parameter, then chains with the other constructor
        public Employee(string name) : this(name, 1)
        {
        }
        public Employee( string name, int employeeNumber){
            this.employeeName = name;
            this.employeeNumber = employeeNumber;
            Console.WriteLine("Creating new record for the upcoming employee with variable string and employeeNumber.");
        }
    }
}
