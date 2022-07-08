using System;

namespace Sum
    
{
    class Add
    {
        public void addnumber(int x,int y)
        {
            Console.WriteLine(x + y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Add x = new Add();
            x.addnumber(4, 5);
            Console.WriteLine();
        }
    }
}
