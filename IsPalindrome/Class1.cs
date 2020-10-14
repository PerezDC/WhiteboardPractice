using System;

namespace IsPalindrome
{
    public class Class1
    {
        public static bool IsPalindrome(string inputString)
        {
            bool isPalindrome = true;
            string tempInputString = inputString.ToUpper();
            string cleanText = "";

            /* Cleaning the input string */
            for (int i = 0; i < inputString.Length; i++)
            {
                if (tempInputString[i] > 'Z' || tempInputString[i] < 'A')
                {
                    continue;
                }
                cleanText += tempInputString[i];
            }

            /* Checking if clean string is palindrome */
            for (int i = 0; i < cleanText.Length; i++)
            {
                if (cleanText[i] != cleanText[cleanText.Length-1-i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }
    }
}
