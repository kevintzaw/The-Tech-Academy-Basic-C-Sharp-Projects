using System;

namespace Branching_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Package Weight
            Console.WriteLine("What is your Package Weight?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("It's above the Weight Limit");
            }
            else
            {
                //Package Width
                Console.WriteLine("What is your Package Width?");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                //Package Height
                Console.WriteLine("What is your Package Height?");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                //Package Length
                Console.WriteLine("What is your Package Length?");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                if (packageWidth > 50 | packageHeight > 50 | packageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    int shippingTotal = ((packageHeight * packageLength * packageWeight) / 100);
                    //Estimated Total for Shipping
                    Console.WriteLine("Your estimated total for shipping this package is:" + shippingTotal);
                }
            }
            }
        }
}
