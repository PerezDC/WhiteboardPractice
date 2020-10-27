using System;

namespace IsPalindromSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string test1 = "Anna"; // FALSE
            string test2 = "civic"; // TRUE
            string test3 = "palindrome"; // FALSE
            string test4 = "i did, did i?"; //TRUE

            Console.WriteLine(IsPalindrome(test1));
            Console.WriteLine(IsPalindrome(test2));
            Console.WriteLine(IsPalindrome(test3));
            Console.WriteLine(IsPalindrome(test4));

        }

        static bool IsPalindrome(string inputString)
        {
            bool isPalindrome = true;
            string cleanString = "";

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString.ToUpper()[i] >= 'A' && inputString.ToUpper()[i] <= 'Z' || inputString[i] == ' ')
                {
                    cleanString += inputString[i];
                }
            }

            int j = cleanString.Length - 1;

            for (int i = 0; i < cleanString.Length; i++)
            {
                if (cleanString[i] != cleanString[j])
                {
                    isPalindrome = false;
                    break;
                }

                j--;
            }

            return isPalindrome;
        }
    }
}
