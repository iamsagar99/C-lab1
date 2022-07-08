using System;

namespace SI
{
    class SI
    {
        public void simpleInterest(int x,int y, int z)
        {
            float si = float.Parse(x * y * z * 0.01);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter p,t,r");
            int p = Convert.ToInt32(Console.ReadLine());
            int t = Convert.ToInt32(Console.ReadLine());
            int r = Convert.ToInt32(Console.ReadLine());

        }
    }
}
