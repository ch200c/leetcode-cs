using System.Linq;

namespace LeetCode.P242;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        var orderedS = s.OrderBy(c => c);
        var orderedT = t.OrderBy(c => c);

        return orderedS.SequenceEqual(orderedT);
    }
}
