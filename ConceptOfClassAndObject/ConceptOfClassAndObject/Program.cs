using System;
// this also illustrates use of constructor
namespace ConceptOfClassAndObject
{
    class Sum
    { int a, b;
        public Sum(int x,int y)
        {
            a = x;
            b = y;
        }
        public int add()
        {
            return (a+b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sum s = new Sum(2, 3);
            Console.WriteLine(s.add());
        }
    }
}
