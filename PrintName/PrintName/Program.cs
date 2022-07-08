using System;

namespace PrintName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string address;
            int roll;
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter address");
            address = Console.ReadLine();
            Console.WriteLine("Enter roll");
            roll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:{0}\nAddress:{1}\nRoll:{2}", name, address, roll);
            Console.WriteLine();
        }
    }
}
