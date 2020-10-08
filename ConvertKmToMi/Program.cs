using System;

namespace ConvertKmToMi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertKmToMi(3.18));

        }

        public static double ConvertKmToMi(double miles) => miles * 1.6;
    }
}
