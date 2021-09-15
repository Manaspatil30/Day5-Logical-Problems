using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    class swapNum
    {
        public static void swap()
        {
            int a;
            int b;

            Console.WriteLine("Enter value of a");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b; //a=50 (5*10)      
            b = a / b; //b=5 (50/10)      
            a = a / b; //a=10 (50/5)    
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}
