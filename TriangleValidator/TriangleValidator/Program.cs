/*5. Write a program to read three sides of triangle and print area for valid data and to print “Invalid data” if either one 
 * side of the triangle is greater or equals to the sum of other two sides.*/


using System;

namespace TriangleValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sides of triangle:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b < c || a + c < b || b + c < a)
            {
                Console.WriteLine("Invalid data");
            }
            else
            {
                double s = (a+b+c)/2.0;

                double area = Math.Sqrt(s * (s + a) * (s + b) * (s + c));
                Console.WriteLine("The area is " + area);
            }    
        }
    }
}
