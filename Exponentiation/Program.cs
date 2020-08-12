using System;
using System.Transactions;

namespace Exponentiation
{
    class Program
    {

        public static double Power(double x, int n)
        {
            if (n == 0)
                return 1;
            return x * Power(x, n - 1);
        }
        static void Main(string[] args)
        {
           double x;
            int n;
            Console.Write(" Enter the values of x and n ");

            x = Convert.ToInt32(Console.ReadLine());

            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x + "^" + n + "=" + Power(x, n));

        }
    }
}
