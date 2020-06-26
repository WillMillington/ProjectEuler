using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ProjectEuler
{
    public class LargestPrimeFactor
    {
        public static long LargestPrimeFactorMehtod(long num)
        {
            long number = num;
            long divisor = 2; 
            long largestDivisor = 0;
            while (divisor <= number / 2.0)
            {
                if (number % divisor != 0)
                {
                    divisor++;
                }
                else
                {
                    number = number / divisor;
                    largestDivisor = divisor;
                    divisor = 2;
                }
            }
            return number;
        }
    }
}
