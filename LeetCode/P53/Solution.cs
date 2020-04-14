namespace LeetCode.P53
{
    public class Solution
    {
        // Runtime: 448 ms (5.84 %)
        // Memory Usage: 25.5 MB
        public int MaxSubArray(int[] nums)
        {
            var largestSum = int.MinValue;

            for (var i = 0; i < nums.Length; ++i)
            {
                var sum = nums[i];

                if (sum > largestSum)
                {
                    largestSum = sum;
                }

                for (var j = i + 1; j < nums.Length; ++j)
                {
                    sum += nums[j];

                    if (sum > largestSum)
                    {
                        largestSum = sum;
                    }
                }
            }

            return largestSum;
        }
    }
}
