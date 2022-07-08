//9.Write a program to read average temperature of a day in Fahrenheit to print. Nice day" if temperature is greater than 60
// but less than 80.
//"Cold day" if temperature is 60 or lower.
//"Hot day" if temperature is 80 higher.



using System;

namespace DayTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature:");
            int t = Convert.ToInt32(Console.ReadLine());

            if (t > 60 && t < 80)
            {
                Console.WriteLine("Nice day");
            }
            else if (t <= 60)
            {
                Console.WriteLine("Cold day");
            }
            else if (t >= 80)
            {
                Console.WriteLine("Hot day.");
            }
            else
                Console.WriteLine("data can't be processed");
        }
    }
}
