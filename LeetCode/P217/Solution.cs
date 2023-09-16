using System.Collections.Immutable;

namespace LeetCode.P217;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var set = ImmutableHashSet.Create(nums);
        return set.Count != nums.Length;
    }
}
