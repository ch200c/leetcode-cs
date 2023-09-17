using System.Linq;

namespace LeetCode.P347;

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        return nums
            .GroupBy(n => n)
            .OrderByDescending(grouping => grouping.Count())
            .Take(k)
            .Select(grouping => grouping.Key)
            .ToArray();
    }
}
