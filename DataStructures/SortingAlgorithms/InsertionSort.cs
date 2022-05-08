using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SortingAlgorithms
{
    public class InsertionSort
    {
        public static int[] SimpleInsertionSort(int[] num)
        {
            int current = 0;
            int previous = 0;
            for (int i = 1; i < num.Length; i++)
            {
                current = num[i];
                previous = i - 1;
                while (previous >= 0 && num[previous] > current)
                {
                    num[previous + 1] = num[previous];
                    previous--;
                }
                num[previous + 1] = current;

            }
            return num;
        }
    }
}
