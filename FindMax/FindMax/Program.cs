//6. Write a program to read four integer numbers and print the maximum.
//  6 3 8 4

using System;

namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            int max = 0;
            if(a>max)
            {
                max = a;
            }
             if(b>max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            if(d>max)
            {
                max = d;
            }
            Console.WriteLine("MAx is"+max);
        }
    }
}
