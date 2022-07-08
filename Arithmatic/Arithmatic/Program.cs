using System;

namespace Arithmatic
{ 
    class Sum
    {
        int x, y;
        public Sum(int a,int b)
        {
            x = a;
            y = b;
        }
        public void add()
        {
            Console.WriteLine("sum is:"+(x + y));
        }
    }
    class Differernce
    {
        public void subtract(int x, int y)
        {
            Console.WriteLine("difference"+(x+y));
        }
    }
    class Product
    {
        public void multiply(int x, int y)
        {
            Console.WriteLine("product"+(x * y));
        }
    }
    class quotent
    {
        public void divide(int x,int y)
        {
            Console.WriteLine("quotent"+(x / y));
        }
    }
   

    class Program
    {
        static void Main(string[] args)
        {

            string x,y;
            Console.WriteLine("Enter two numbers:");
            x = Console.ReadLine();
            y = Console.ReadLine();
            int a = Convert.ToInt32(x);
            int b = Convert.ToInt32(y);

            Sum s = new Sum(a,b);
            s.add();
            Differernce d = new Differernce();
            d.subtract(a, b);
            Product p = new Product();
            p.multiply(a, b);
            quotent q = new quotent();
            q.divide(a, b);
            Console.ReadLine();






        }
    }
}
