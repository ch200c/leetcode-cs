using System;
using System.Collections.Generic;

namespace LeetCode.P525
{
    public class Solution
    {
        // Runtime: 228 ms (58.18 %)
        // Memory Usage: 43.7 MB
        public int FindMaxLength(int[] nums)
        {
            var countToIndex = new Dictionary<int, int>
            {
                [0] = -1
            };

            var maxLength = 0;
            var count = 0;

            for (var i = 0; i < nums.Length; ++i)
            {
                count += nums[i] == 1 ? 1 : -1;

                if (countToIndex.ContainsKey(count))
                {
                    maxLength = Math.Max(maxLength, i - countToIndex[count]);
                }
                else
                {
                    countToIndex[count] = i;
                }
            }

            return maxLength;
        }
    }
}
