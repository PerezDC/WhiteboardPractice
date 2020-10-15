using System;
using System.Collections.Generic;

namespace IntToRoman
{
    public class Class1
    {
        public string IntToRoman(int num)
        {
            string romanValue = "";

            Dictionary<string, int> romanValues = new Dictionary<string, int>();
            romanValues.Add("I", 1);
            romanValues.Add("IV", 4);
            romanValues.Add("V", 5);
            romanValues.Add("IX", 9);
            romanValues.Add("X", 10);
            romanValues.Add("XL", 40);
            romanValues.Add("L", 50);
            romanValues.Add("XC", 90);
            romanValues.Add("C", 100);

            while (num != 0)
            {
                if (num == romanValues(num))
                {
                    romanValue += romanValues(num);
                    num = 0;
                    continue;
                }

                if (num < 4 && num > 1)
                {
                    romanValue += "I";
                    num -= 1;
                    continue;
                }

                if (num > 5 && num < 9)
                {
                    romanValue += "V";
                    num -= 5;
                    continue;
                }

                if (num > 10 && num < 40)
                {
                    romanValue += "X";
                    num -= 10;
                    continue;
                }

                if (num > 40 && num < 50)
                {
                    romanValue += "XL";
                    num -= 40;
                    continue;
                }

                if (num > 50 && num < 90)
                {
                    romanValue += "L";
                    num -= 50;
                    continue;
                }

                if (num > 90 && num < 100)
                {
                    romanValue += "C";
                    num -= 10;
                    continue;
                }
            }

            return romanValue;
        }
    }
}