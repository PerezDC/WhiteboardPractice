using System;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(LetterSort());

            int x;
            int value1 = 1;
            do
            {

            } while (value1-- > 0);

            Console.WriteLine(value1);
        }


        public static string LetterSort(string inputString = "apple")
        {
            string sortedString = "";
            for (int i = 0; i < inputString.Length; i++)
            {
                for (int j = 0; j < inputString.Length; j++)
                {
                    if (inputString[i] == inputString[j])
                    {
                        continue;
                    }
                    if (inputString[i] < inputString[j])
                    {
                        sortedString += inputString[i];
                    }
                }
            }

            return sortedString;
        }


	}
}
