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

            if (s.Length == 1)
            {
                romanIntValue += romanValues[s[0].ToString()];
            }
            else
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {

                    if (i == 0 && romanValues[s[i].ToString()] >= romanValues[s[i + 1].ToString()])
                    {
                        romanIntValue += romanValues[s[i].ToString()];
                        break;
                    }

                    else if (i == 0 && romanValues[s[i].ToString()] < romanValues[s[i + 1].ToString()])
                    {
                        romanIntValue -= romanValues[s[i].ToString()];
                        break;
                    }

                    if (i == s.Length - 1)
                    {
                        romanIntValue += romanValues[s[i].ToString()];
                        continue;
                    }

                    else if (i > 0 && romanValues[s[i].ToString()] >= romanValues[s[i + 1].ToString()])
                    {
                        romanIntValue += romanValues[s[i].ToString()];
                        continue;
                    }

                    else if (i > 0 && romanValues[s[i].ToString()] < romanValues[s[i + 1].ToString()])
                    {
                        romanIntValue -= romanValues[s[i].ToString()];
                        continue;
                    }
                }
            }

            return romanIntValue;
        }
    }
}