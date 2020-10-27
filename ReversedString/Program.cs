using System;

namespace ReversedString
{
    class Program
    {
        static void Main(string[] args)
        {
			string test1 = "fox";
            string test2 = "banana";
            string test3 = "moonlight";
            string test4 = "Cats and Dogs";

            Console.WriteLine(ReverseString(test1));
            Console.WriteLine(ReverseString(test2));
            Console.WriteLine(ReverseString(test3));
			Console.WriteLine(ReverseString(test4));

		}

		/********************************************************************
        create a method that receives a string and returns the reversed value

		no spaces or other symbols
		input string
		output string
		
		strings 
			inputString
			reversedString
		
		for loop to iterate through my input string
			if loop to filter our characters other than letters
		
		return
			reversedString
		
		string test1 = "fox";
		string test2 = "banana";
		string test3 = "moonlight";
		
		********************************************************************/

		static string ReverseString(string inputString)
		{
			string reversedString = "";

			for (int i = inputString.Length - 1; i >= 0; i--)
			{
				if (inputString.ToUpper()[i] > 'Z' || inputString.ToUpper()[i] < 'A')
				{
					continue;
				}

				reversedString += inputString[i];
			}

			return reversedString;
		}
	}
}
