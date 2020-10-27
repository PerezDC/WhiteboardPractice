using System;
using System.Collections.Generic;

namespace CheckEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Scrabble());
        }

        public static int Scrabble()
        {
            Console.WriteLine("Enter String");
            string inputString = Console.ReadLine();
            int stringValue = 0;
            string tempString = inputString.ToUpper();

            Dictionary<char, int> letterValue = new Dictionary<char, int>();
            letterValue.Add('A', 1);
            letterValue.Add('B', 3);
            letterValue.Add('C', 3);
            letterValue.Add('D', 2);
            letterValue.Add('E', 1);
            letterValue.Add('F', 4);
            letterValue.Add('G', 2);
            letterValue.Add('H', 4);
            letterValue.Add('I', 1);
            letterValue.Add('J', 8);
            letterValue.Add('K', 5);
            letterValue.Add('L', 1);
            letterValue.Add('M', 3);
            letterValue.Add('N', 1);
            letterValue.Add('O', 1);
            letterValue.Add('P', 3);
            letterValue.Add('Q', 10);
            letterValue.Add('R', 1);
            letterValue.Add('S', 1);
            letterValue.Add('T', 1);
            letterValue.Add('U', 1);
            letterValue.Add('V', 4);
            letterValue.Add('W', 4);
            letterValue.Add('X', 8);
            letterValue.Add('Y', 4);
            letterValue.Add('Z', 10);

            for (int i = 0; i < tempString.Length; i++)
            {
                if (tempString[i] < 'A' || tempString[i] > 'Z')
                {
                    continue;
                }

                stringValue += letterValue[tempString[i]];
            }

            return stringValue;
        }

    }
}
