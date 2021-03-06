using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] quarters = {1,2,3,4};
            int[] sales = {100000, 150000, 200000, 225000};
            double[] intlMixPct = {.386, .413, .421, .457};
            string str1 = "TestStr";
            int val1 = 1234;
            decimal val2 = 1234.5678m;

            // Basic Formatting information
            // Console.WriteLine("{0}", str1);

            Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}", val1);
            Console.WriteLine("{0:E}, {0:N}, {0:F}, {0:G}", val2);

            Console.WriteLine("{0:D6}, {0:N2}, {0:F1}, {0:G3}", val1);

            Console.WriteLine("{0,12} {1,12} {2,12} {3,12}", sales[0], sales[1], sales[2], sales[3]);


            // TODO: Add a number after the format to specify precision


            // TODO: Formatting with alignment and spacing

        }
    }
}
