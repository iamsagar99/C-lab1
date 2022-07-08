//7.Write a program to read three numbers and display the following menu. Menu:
//1.Summation
//2.Sum of squares
//3. Sum of cubes
//4. Product
//and perform tasks as per user’s choice. (use switch statements)


using System;

namespace Switch_ArithmaticOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("MENU\n1.Summation\n2.Sum of squares\n3. Sum of cubes\n4. Product\nEnter your choice:");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.WriteLine("sum is {0}", a + b + c);
                    break;
                case 2:
                    Console.WriteLine("sum of square {0}", a*a+ b*b+ c*c);
                    break;
                case 3:
                    Console.WriteLine("sum of cube {0}", a * a * a+b * b * b + c*c * c);
                    break;
                case 4:
                    Console.WriteLine("product {0}", a *b * c);
                    break;
                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }

        }
    }
}
