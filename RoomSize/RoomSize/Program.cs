/*4. Write a program to read to read length and breadth of a room and print area and print. 
 * “Auditorium” if area >2500
“Hall” if 500 < = area <=2500
“Big room” if 150 < area < 500
“Small room” if area < = 150*/


using System;

namespace RoomSize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length and breadth of room:");
            int l = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int a = l * b;
            if (a > 2500)
            {
                Console.WriteLine("Auditorium.");
            }
            else if (a >= 500 && a <= 2500)
            {
                Console.WriteLine("Hall");
            }
            else if(a>150 &&a < 500)
            {
                Console.WriteLine("Big room");
            }
            else if(a<=150)
            {
                Console.WriteLine("Small Room");
            }
        }
    }
}
