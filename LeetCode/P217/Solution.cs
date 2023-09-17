using System.Linq;

namespace LeetCode.P217;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var set = nums.ToHashSet();
        return set.Count != nums.Length;
    }
}
