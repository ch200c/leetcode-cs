using System.Collections.Generic;

namespace LeetCode.P283
{
    public class Solution
    {
        // Runtime: 252 ms (33.96 %)
        // Memory Usage: 31.9 MB
        public void MoveZeroes(int[] nums)
        {
            var nonZeroes = new List<int>();

            for (var i = 0; i < nums.Length; ++i)
            {
                if (nums[i] != 0)
                {
                    nonZeroes.Add(nums[i]);
                }
            }

            for (var i = 0; i < nonZeroes.Count; ++i)
            {
                nums[i] = nonZeroes[i];
            }

            for (var i = nonZeroes.Count; i < nums.Length; ++i)
            {
                nums[i] = 0;
            }
        }
    }
}
