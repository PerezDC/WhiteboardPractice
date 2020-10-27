using System;
using System.Collections.Generic;

namespace SortArray
{
    public class Solution
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            SortedList<int, int> myList = new SortedList<int, int>();

            foreach (int number in arr1)
            {
                if (myList.ContainsKey(number))
                {
                    myList[number]++;
                    continue;
                }
                myList.Add(number, 1);
            }

            foreach (int number in arr2)
            {
                if (myList.ContainsKey(number))
                {
                    myList[number]++;
                    continue;
                }
                myList.Add(number, 1);
            }

            int[] collectiveArr = new int[arr1.Length + arr2.Length - 2];
            int i = 0;

            foreach (var element in myList)
            {
                for (int j = 0; j < element.Value; j++)
                {
                    collectiveArr[i] = element.Key;
                    i++;
                }

            }

            return collectiveArr;
        }
    }
}
