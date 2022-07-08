/*
 
11.An organization is dealing in Two items say A and B and provides the commission on of sale of these items according to the
following policies:
i) ii)
Commission rate for item A is 5% up to a sale of Rs. 2,000. If the sale of item A above 2000 then the commission is 6% on the
extra sale.
For B, 10% up to sale of Rs 4,000 if the sale is above 4,000 commission rate is 12% on extra sale: Given the sales of both
the items, write a program to compute net commission.
 */

using System;

namespace sale
{
    class Program
    {
        static void Main(string[] args)
        {

            int sa, sb;
            double nc, ca, cb;
            Console.WriteLine("Enter the sale for product a\n");
            sa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sale for product b\n");
            sb = Convert.ToInt32(Console.ReadLine());
            if (sa <= 2000)
                ca = (double)(0.05 * 2000);
            else ca = (double)(0.5 * 2000 + 0.06 * (sa - 2000));
            if (sb <= 4000)
                cb = (double)0.1 * 4000;
            else cb = 0.1 * 4000 + 0.12 * (sb - 4000);
            nc = ca + cb;
            Console.WriteLine("Net Commission" + nc);

        }
    }
}
