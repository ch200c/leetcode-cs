namespace LeetCode.P5
{
    public class Solution
    {
        // Runtime: 520 ms, faster than 22.79% of C# online submissions for Longest Palindromic Substring.
        // Memory Usage: 27.2 MB, less than 26.02% of C# online submissions for Longest Palindromic Substring.
        public string LongestPalindrome(string s)
        {
            var longestPalindrome = "";

            for (var i = 0; i < s.Length && longestPalindrome.Length < (s.Length / 2) + 1; i++)
            {
                for (int j = s.Length; j > i; j--)
                {
                    var middleIndex = (i + j) % 2 == 0
                        ? (i + j) / 2
                        : (i + j) / 2 + 1;

                    var firstPartIndex = 0;
                    var isMismatchFound = false;

                    for (var k = j - 1; k >= middleIndex; k--)
                    {
                        if (s[i + firstPartIndex++] != s[k])
                        {
                            isMismatchFound = true;
                            break;
                        }
                    }

                    if (isMismatchFound)
                    {
                        continue;
                    }

                    var palindrome = s[i..j];

                    if (palindrome.Length > longestPalindrome.Length)
                    {
                        longestPalindrome = palindrome;
                    }
                }
            }

            return longestPalindrome;
        }
    }
}
