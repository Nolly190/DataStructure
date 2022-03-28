using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            var isNegativeNumber = false;
            var numArray = new char[x.ToString().Length];
            if (x.ToString().Substring(0, 1) == "-")
            {
                numArray = x.ToString().Substring(1, x.ToString().Length - 1).ToCharArray();
                isNegativeNumber = true;
            }
            else
            {
                numArray = x.ToString().ToCharArray();
            }
            Array.Reverse(numArray);
            string reversedNum = new string(numArray);


            try
            {
                return isNegativeNumber ? Convert.ToInt32('-' + reversedNum) : Convert.ToInt32(reversedNum);
            }
            catch (Exception)
            {
                return 0;
            }

        }
    }
}
