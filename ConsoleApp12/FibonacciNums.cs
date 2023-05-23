using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class FibonacciNums
    {
        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
                if (number % i == 0) return false;
            return true;
        }

        public static bool IsFibonacci(int number)
        {
            int a = 0;
            int b = 1;

            while (number > b)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return number == b;
        }
    }
}
