using System.Collections.Generic;
using System.Text;

namespace LeetCode.P6;

public class Solution
{
    private const int HorizontalPadding = 2;

    // Runtime: 136 ms, (38.25%)
    // Memory Usage: 37.8 MB, (86.98%)
    public string Convert(string s, int numRows)
    {
        var horizontalLines = new List<char>[numRows];

        for (var i = 0; i < numRows; i++)
        {
            horizontalLines[i] = new List<char>();
        }

        var horizontalIndex = 0;
        var isGoingUp = false;

        for (var i = 0; i < s.Length; i++)
        {
            horizontalLines[horizontalIndex].Add(s[i]);

            if (isGoingUp && horizontalIndex <= 0)
            {
                isGoingUp = false;
            }

            horizontalIndex = isGoingUp
                ? horizontalIndex - 1
                : horizontalIndex + 1;

            if (horizontalIndex != 0 && horizontalIndex % numRows == 0)
            {
                isGoingUp = true;

                horizontalIndex = numRows == 1
                    ? 0
                    : horizontalIndex - HorizontalPadding;
            }
        }

        var stringBuilder = new StringBuilder();

        foreach (var horizontalLine in horizontalLines)
        {
            stringBuilder.Append(horizontalLine.ToArray());
        }

        return stringBuilder.ToString();
    }
}