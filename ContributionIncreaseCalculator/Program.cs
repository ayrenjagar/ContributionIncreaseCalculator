using System;
using System.Collections;

namespace ContributionIncreaseCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            decimal monthlyRepaymentAmt = 0;
            decimal increasePercent = 0;
            int termMonths = 0;

            Console.WriteLine($"Enter the monthly contribution amount e.g. 250: ");
            monthlyRepaymentAmt = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Monthly contribution amount is {monthlyRepaymentAmt}");
            Console.WriteLine();

            Console.WriteLine($"Enter the monthly contribution increase percent per annum e.g. 9: ");
            increasePercent = decimal.Parse(Console.ReadLine()) / 100;
            Console.WriteLine($"Yearly increase percent is {increasePercent}");
            Console.WriteLine();

            Console.WriteLine($"Enter the year term of contributions e.g. 10: ");
            termMonths = int.Parse(Console.ReadLine());
            Console.WriteLine($"Term is {termMonths}");
            Console.WriteLine();

            ArrayList termArray = new ArrayList();
            termArray.Add(monthlyRepaymentAmt);
            Console.WriteLine($"Year {1} contribution = R" + string.Format("{0:#.00}", Convert.ToDecimal(termArray[0])));

            for (int i = 2; i <= termMonths; i++)
            {
                termArray.Add((decimal)termArray[i - 2] + (decimal)termArray[i - 2] * increasePercent);
                Console.WriteLine($"Year {i} contribution = R" + string.Format("{0:#.00}", Convert.ToDecimal(termArray[i - 1])));
            }


            Console.ReadLine();
        }
    }
}
