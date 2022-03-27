
using System;

namespace AppZoneTest
{
    internal partial class Program
    {
        public  class MissingArrayNumber
        {
            public static int GetMissingNumber(int[] num)
            {
                if (num.Length == 0)
                {
                    return 0;
                }

                Array.Sort(num);
                var value = num[0];
                var result = num[0];
                var count = 0;
                while (value == result)
                {
                    count++;

                    value = num[count];
                    result = count + num[0];
                }

                return result;
            }
        }

    }
}
