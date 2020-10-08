using System;

namespace CheckEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckEvenNumbers());
        }

        public static int CheckEvenNumbers(int min = 2, int max = 5)
        {
            int sum = 0;

            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

	}
}
