namespace LeetCode.P560
{
    public class Solution
    {
        // Runtime: 692 ms (19.73 %)
        // Memory Usage: 27.1 MB
        public int SubarraySum(int[] nums, int k)
        {
            var count = 0;
            for (var i = 0; i < nums.Length; ++i)
            {
                var sum = 0;
                for (var j = i; j < nums.Length; ++j)
                {
                    sum += nums[j];
                    if (sum == k)
                    {
                        ++count;
                    }
                }
            }

            return count;
        }
    }
}
