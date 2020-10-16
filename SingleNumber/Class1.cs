using System;
using System.Collections.Generic;

namespace SingleNumber
{
    public class SingleNumberSln
    {
        public int SingleNumber(int[] nums)
        {
            int returnNumber = 0;
            Dictionary<int, int> myList = new Dictionary<int, int>();
            foreach (int number in nums)
            {
                if (myList.ContainsKey(number))
                {
                    myList[number] += 1;
                }
                else
                {
                    myList.Add(number, 1);
                }
            }

            foreach (var number in myList)
            {
                if (number.Value == 1)
                {
                    returnNumber = number.Key;
                }
            }

            return returnNumber;
        }
    }
}