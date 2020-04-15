namespace LeetCode.P238
{
    public class Solution
    {
        // Runtime: 264 ms   (53.77 %)
        // Memory Usage: 35.6 MB
        public int[] ProductExceptSelf(int[] nums)
        {
            var output = new int[nums.Length];
            output[0] = 1;  // Accumulate left product

            for (var i = 1; i < nums.Length; ++i)
            {
                output[i] = output[i - 1] * nums[i - 1];
            }

            var rightProduct = 1;
            for (var i = nums.Length - 1; i >= 0; --i)
            {
                output[i] *= rightProduct;
                rightProduct *= nums[i];
            }

            return output;
        }
    }
}
