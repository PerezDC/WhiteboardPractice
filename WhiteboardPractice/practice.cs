using System;

namespace WhiteboardPractice
{
    class practice
    {
        public static string ReverseString(string inputString)
        {
            string tempString = "";

            for (int i = inputString.Length; i > 0; i--)
            {
                tempString += inputString[i - 1];
            }

            return tempString;
        }


        public static int CountCharacters(string inputString)
        {
            int counter = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (Convert.ToString(inputString[i]) == " ")
                {
                    continue;
                }
                else
                {
                    counter++;
                }
            }
            return counter;
        }

    }

}