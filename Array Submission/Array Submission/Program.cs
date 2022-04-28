using System;
using System.Collections.Generic;

namespace Array_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //dimension of integers
            int[] numArray = new int[4];
            numArray[0] = 6;
            numArray[1] = 2;
            numArray[2] = 7;
            numArray[3] = 10;

            Console.WriteLine("Choose a Number from 0-3");
            int submitInteger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numArray[submitInteger]);
            if ( submitInteger < 4) {
                Console.ReadLine();
            } else {
                Console.WriteLine("You didn't pick a number from 0-3");
            }

            //dimension of string
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
                
            Console.WriteLine("Choose a Number from 0-3");
            int submitString = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(cars[submitInteger]);
            if (submitString < 4) {
                Console.ReadLine();
            } else {
                Console.WriteLine("You didn't pick a number from 0-3");
            }

            //list creation
            Console.WriteLine("Choose a Number from 0-2");
            string[] authors = { "Mike", "Jeff", "Steve" };
            List<string> authorList = new List<string>(authors);
            authorList.Add("Logan");
            authorList.Add("Jesse");
            int submitList = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(authors[submitList]);





            Console.WriteLine(authorList[0]);
            Console.ReadLine();

        }
    }
}
