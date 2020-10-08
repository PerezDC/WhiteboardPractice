using System;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LetterSort());
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
