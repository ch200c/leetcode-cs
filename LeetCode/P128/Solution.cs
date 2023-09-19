using System;
using System.Linq;

namespace LeetCode.P128;

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var longestConsecutiveCount = 0;
        var consecutiveCount = 0;
        int? previousNumber = null;

        foreach (var number in nums.ToHashSet().OrderBy(n => n))
        {
            if (previousNumber != null)
            {
                if (Math.Abs(number - previousNumber.Value) == 1)
                {
                    consecutiveCount++;
                }
                else
                {
                    longestConsecutiveCount = Math.Max(longestConsecutiveCount, consecutiveCount);
                    consecutiveCount = 1;
                }
            }
            else
            {
                consecutiveCount++;
            }

            previousNumber = number;
        }

        return Math.Max(longestConsecutiveCount, consecutiveCount);
    }
}
