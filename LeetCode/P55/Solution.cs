namespace LeetCode.P55
{
    public class Solution
    {
        // Runtime: 92 ms (96.32%)
        // Memory Usage: 26.1 MB
        public bool CanJump(int[] nums)
        {
            var lastIndex = nums.Length - 1;
            for (var i = lastIndex; i >= 0; i--)
            {
                if (nums[i] + i >= lastIndex)
                {
                    lastIndex = i;
                }
            }

            return lastIndex == 0;
        }
    }
}
