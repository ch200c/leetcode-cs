using System;
using System.Linq;

namespace LeetCode.P125;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        var asciiLowerCaseInput = s
            .Where(char.IsLetterOrDigit)
            .Select(char.ToLowerInvariant)
            .ToList();

        var secondHalfStartIndex = asciiLowerCaseInput.Count % 2 == 0
            ? asciiLowerCaseInput.Count / 2
            : (asciiLowerCaseInput.Count / 2) + 1;

        var firstHalf = asciiLowerCaseInput.Take(asciiLowerCaseInput.Count / 2);
        var secondHalf = asciiLowerCaseInput.Skip(secondHalfStartIndex);

        return firstHalf.SequenceEqual(secondHalf.Reverse());
    }
}