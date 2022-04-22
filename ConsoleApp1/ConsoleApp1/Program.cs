using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            
            //Person 1 Information
            Console.WriteLine("Person 1 - What is your Hourly Rate?");
            string person1HourlyRate = Console.ReadLine();
            Console.WriteLine("Hourly Rate is: " + person1HourlyRate);
            int p1HourlyRate = Convert.ToInt32(person1HourlyRate);
            Console.WriteLine("Person 1 - What is your Hours Per Week?");
            string person1HoursPerWeek = Console.ReadLine();
            Console.WriteLine("Hours Per Week: " + person1HoursPerWeek);
            int p1HoursPerWeek = Convert.ToInt32(person1HoursPerWeek);

            //Person 2 Information
            Console.WriteLine("Person 2 - What is your Hourly Rate?");
            string person2HourlyRate = Console.ReadLine();
            Console.WriteLine("Hourly Rate is: " + person2HourlyRate);
            int p2HourlyRate = Convert.ToInt32(person2HourlyRate);
            Console.WriteLine("Person 2 - What is your Hours Per Week?");
            string person2HoursPerWeek = Console.ReadLine();
            Console.WriteLine("Hours Per Week: " + person2HoursPerWeek);
            int p2HoursPerWeek = Convert.ToInt32(person2HoursPerWeek);

            //Annual Salaries
            int p1Total = p1HourlyRate * p1HoursPerWeek;
            Console.WriteLine("Person 1 - This is your Annual Salary");
            Console.WriteLine(p1Total.ToString());
            int p2Total = p2HourlyRate * p2HoursPerWeek;
            Console.WriteLine("Person 2 - This is your Annual Salary");
            Console.WriteLine(p2Total.ToString());

            //Comparisons
            Console.WriteLine("Does Person 1 Make More Money than Person 2?");
            bool trueOrFalse = p1Total > p2Total;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();
        }
    }
}
