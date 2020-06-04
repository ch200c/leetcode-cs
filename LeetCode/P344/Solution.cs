namespace LeetCode.P344
{
    public class Solution
    {
        // Runtime: 364 ms (98.28%)
        // Memory Usage: 34.7 MB
        public void ReverseString(char[] s)
        {
            for (var i = 0; i < s.Length / 2; i++)
            {
                var previousChar = s[i];
                s[i] = s[^(i + 1)];
                s[^(i + 1)] = previousChar;
            }
        }
    }
}
