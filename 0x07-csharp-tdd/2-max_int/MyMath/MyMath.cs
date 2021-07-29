using System;
using System.Collections.Generic;
namespace MyMath
{
    /// <summary>Operations class conrains one methode Max().</summary>
    public class Operations
    {
        /// <summary>A method that returns the max integer in a list of integers.</summary>
        /// <param name="nums">A list of integers.</param>
        /// <return>The Maximum number in the list nums.</return>
        public static int Max(List<int> nums)
        {
            int max = int.MinValue;
            if (nums.Count > 0)
            {
                foreach (var item in nums)
                {
                    if (max < item)
                        max = item;
                }
                return max;
            }
            else
                return 0;
        }
    }
}
