using System;
using System.Collections.Generic;

namespace RomanToInteger
{
    public class Solution
    {
        public static int RomanToInt(string s)
        {
            int romanIntValue = 0;

            Dictionary<string, int> romanValues = new Dictionary<string, int>();
            romanValues.Add("I", 1);
            romanValues.Add("V", 5);
            romanValues.Add("X", 10);
            romanValues.Add("L", 50);
            romanValues.Add("C", 100);
            romanValues.Add("D", 500);
            romanValues.Add("M", 1000);

            romanIntValue += romanValues[s[s.Length - 1].ToString()];

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    romanIntValue += romanValues[s[i].ToString()];
                    break;
                }

                if (romanValues[s[i].ToString()] > romanValues[s[i - 1].ToString()])
                {
                    romanIntValue -= romanValues[s[i].ToString()];
                }

                if (romanValues[s[i].ToString()] <= romanValues[s[i - 1].ToString()])
                {
                    romanIntValue += romanValues[s[i].ToString()];
                }


            }

            return romanIntValue;
        }
    }
}
