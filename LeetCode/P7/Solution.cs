using System.Linq;

namespace LeetCode.P7
{
    public class Solution
    {
        // Runtime: 48 ms (37.40%)
        // Memory Usage: 16.5 MB (10.35%)
        public int Reverse(int x)
        {
            var isNegative = x < 0;
            var reversedX = isNegative
                ? x.ToString()[1..].Reverse().ToArray()
                : x.ToString().Reverse().ToArray();

            if (int.TryParse(reversedX, out var answer))
            {
                return isNegative
                    ? -answer
                    : answer;
            }

            return 0;
        }
    }
}
