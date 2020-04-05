using System.Collections.Generic;

namespace LeetCode.P283
{
    public class Solution
    {
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
