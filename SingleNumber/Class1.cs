using System;
using System.Collections.Generic;

namespace SingleNumber
{
    public class SingleNumberSln
    {
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> myList = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (myList.ContainsKey(nums[i]))
                {
                    myList.Add(nums[i], +1);
                }
                else
                {
                    myList.Add(nums[i], 1);
                }
            }

            int returnInt = fin
        }
    }
}