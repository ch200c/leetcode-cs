using System;

namespace LeetCode.P678
{
    public class Solution
    {
        // Runtime: 76 ms (64.86 %)
        // Memory Usage: 21.8 MB
        public bool CheckValidString(string s)
        {
            var minOpenCount = 0;
            var maxOpenCount = 0;

            foreach (var c in s)
            {
                minOpenCount += c == '(' ? 1 : -1;
                maxOpenCount += c != ')' ? 1 : -1;

                if (maxOpenCount < 0)
                {
                    break;
                }

                minOpenCount = Math.Max(minOpenCount, 0);
            }

            return minOpenCount == 0;
        }
    }
}
