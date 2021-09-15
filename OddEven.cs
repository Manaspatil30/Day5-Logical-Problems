using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    class OddEven
    {
        public static void getOddEven()
        {
            int i;
            Console.Write("Enter a Number : ");
            i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
            }
        }
    }
}
