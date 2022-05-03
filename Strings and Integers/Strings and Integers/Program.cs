using System;
using System.Collections.Generic;

namespace Strings_and_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of Integers
            List<int> myValues = new List<int>();
            myValues.Add(1);
            myValues.Add(3);
            myValues.Add(4);
            myValues.Add(22);
            myValues.Add(35);

            try
            {
                //User Input
                //Asking User to input number
                Console.Write("Pick a number: ");
                string inputNumber = Console.ReadLine();
                int valueNumber = Convert.ToInt32(inputNumber);

                if (valueNumber == 0)
                {
                    Console.WriteLine("0 doesn't work");
                }

                else
                {
                    //divides each number in list
                    for (int j = 0; j < myValues.Count; j++)
                    {
                        int dividedList = valueNumber / myValues[j];
                        Console.WriteLine(dividedList);
                    }
                }
            }



            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
