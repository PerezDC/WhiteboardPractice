using System;
using System.Collections.Generic;

namespace TwoNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[4] { 2, 7, 11, 15 };
            int result = 9;

            Console.WriteLine(TwoSum(nums1, result));
            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] twoNumbers = new int[2];
            List<int> storedInt = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (storedInt.Contains(target-nums[i]))
                {
                    twoNumbers[0] = storedInt.IndexOf(target - nums[i]);
                    twoNumbers[1] = i;
                    break;
                }
                else
                {
                    storedInt.Add(nums[i]);
                }
            }
            return twoNumbers;
        }
    }
}
