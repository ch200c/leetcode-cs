using System.Collections.Immutable;
using System.Linq;

namespace LeetCode.P242;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        var characterOccurrence1 = GetCharacterOccurrence(s);
        var characterOccurrence2 = GetCharacterOccurrence(t);

        return characterOccurrence1.SequenceEqual(characterOccurrence2);
    }

    private static ImmutableSortedDictionary<char, int> GetCharacterOccurrence(string input)
    {
        return input
            .GroupBy(c => c)
            .ToImmutableSortedDictionary(grouping => grouping.Key, grouping => grouping.Count());
    }
}
