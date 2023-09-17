using System;

namespace LeetCode.P238;

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var product = 1;
        var zeroCount = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                zeroCount++;

                if (zeroCount > 1)
                {
                    Array.Fill(nums, 0);
                    return nums;
                }
            }
            else
            {
                product *= nums[i];
            }
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (zeroCount == 0)
            {
                nums[i] = product / nums[i];
            }
            else
            {
                nums[i] = nums[i] != 0
                    ? 0
                    : product;
            }
        }

        return nums;
    }
}
