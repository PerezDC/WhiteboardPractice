using System;

namespace IsPrimeNumber
{
    public class Solution
    {
        public static bool NumberPrime(int inputNum)
        {
            bool isPrime = false;

            if (inputNum % 2 != 0)
            {
                for (int i = 2; i < inputNum; i++)
                {
                    if (inputNum % i == 0)
                    {
                        isPrime = false;
                    }

                    if (i == inputNum - 1)
                    {
                        isPrime = true;
                    }
                }
            }

            return isPrime;
        }
	}
}
