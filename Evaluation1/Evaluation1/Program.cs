//10 Write a program to evaluate the expression (i) a + b (ii) a – b (iii) a x b (iv) a/b (v) Remainder of a/b.
using System;

namespace Evaluation1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of a and b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a+b:" + (a + b));
            Console.WriteLine("a*b:" + a * b);
            Console.WriteLine("a/b:" + a / b);
            Console.WriteLine("a%b:" + a % b);


        }
    }
}
