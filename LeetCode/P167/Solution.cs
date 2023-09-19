using System;

namespace LeetCode.P167;

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var i = 0;
        var j = numbers.Length - 1;

        while (i < j)
        {
            var sum = numbers[i] + numbers[j];

            if (sum == target)
            {
                return new int[] { i + 1, j + 1 };
            }

            if (sum > target)
            {
                j--;
            }
            else
            {
                i++;
            }
        }

        return Array.Empty<int>();
    }
}
