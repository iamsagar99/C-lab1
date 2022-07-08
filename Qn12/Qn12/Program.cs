/*
 12 .A bank accepts deposit for 1 year or more and the policies it adopts on interest rate as follows:
i) if deposit is less than Rs. 1,000 and for 2 or more years than interest rate is 5% compounded annually
ii) If the deposit is Rs 1,000 or more but less then Rs. 5,000 and for 2 or more years the interest rate 7% compounding annually.
iii) If deposit is more then Rs. 5,000 and is for one year or more the interest rate is 8% compound annually.
iv) On all deposit for 5 years or more, interest is 10% compounded annually
v) On all other deposit not covered by the above conditions the interest is 3% compounded
annually.
At the time of withdrawal, costumer’s data is given with amount deposited and the number of years the money has been with the
bank. Write a program to obtain the total money in the costumer’s account and the interest credited at the time of withdrawal.

 */


using System;

namespace Qn12
{
    class Program
    {
        static void Main(string[] args)
        {

            int d;
            int t;
            double rate, total;
            Console.WriteLine("Enter the deposit\n");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the time\n");
            t = Convert.ToInt32(Console.ReadLine());
            if (t >= 1)
            {
                if (d < 1000 && t >= 2)
                    rate = 0.05;
                if (d >= 1000 && d < 5000 && t >= 2)
                    rate = 0.07;
                if (d > 5000 && t >= 1)
                    rate = 0.08;
                if (t >= 5)
                    rate = 0.1;
            }
            else
            {
                rate = 0.03;
            }

            total = d + d * rate
            Console.WriteLine("Total"+ total);
        }
    
    }
}
