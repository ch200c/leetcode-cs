using System;

namespace LeetCode.P1
{
    public class Solution
    {
        // Runtime: 328 ms, faster than 49.45% of C# online submissions for Two Sum.
        // Memory Usage: 32.7 MB, less than 41.08% of C# online submissions for Two Sum.
#pragma warning disable CA1822 // Mark members as static
        public int[] TwoSum(int[] nums, int target)
#pragma warning restore CA1822 // Mark members as static
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            throw new InvalidOperationException("Could not find indices for target");
        }
    }
}
