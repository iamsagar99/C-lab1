//10. Write a program to read 3-digits number and test whether it is a Armstrong number or not Armstrong.

using System;

namespace Armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to check:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int r;
            int n1 = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            if (sum == n1)
                Console.WriteLine("Armstrong");
            else
                Console.WriteLine("Not armstrong.");
        }
    }
}
