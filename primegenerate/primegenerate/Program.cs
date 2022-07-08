using System;

namespace primegenerate
{
    class PrimeCheck
    {
         int lb;
         int ub;
        public PrimeCheck(int a,int b)
        {
            lb = a;
            ub = b;
        }
        public void Generate()
        {
            for (int j = lb; j <= ub; j++)
            {
                bool flag = true;
                for (int i = 2; i <= j / 2; i++)
                {
                    if (j % i == 0)
                    {
                        flag = false;
                        break;

                    }
                }
                if (flag)
                    Console.WriteLine(j);

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 100;
            PrimeCheck pc = new PrimeCheck(a,b);

            pc.Generate();
            Console.WriteLine();
        }
    }
}
