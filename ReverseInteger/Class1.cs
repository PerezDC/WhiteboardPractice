using System;

namespace ReverseInteger
{
    public class Solution
    {
        public static int Reverse(int x)
        {
            try
            {

                bool isNegative = false;
                string revValue = "";
                if (x < 0)
                {
                    isNegative = true;
                    x *= -1;
                }

                for (int i = Convert.ToString(x).Length - 1; i >= 0; i--)
                {
                    revValue += Convert.ToString(x)[i];
                }

                int revInt = Int32.Parse(revValue);

                if (isNegative == true)
                {
                    revInt *= -1;
                }

                return revInt;
            }
            catch (OverflowException e)
            {
                return 0;
            }
            catch (FormatException ex)
            {
                return 0;
            }
        }
    }
}
