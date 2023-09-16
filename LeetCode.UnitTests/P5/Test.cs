using LeetCode.P5;
using Xunit;

namespace LeetCode.UnitTests.P5
{
    public class Test
    {
        [Theory]
        [InlineData("babad")]
        public void Test1(string s)
        {
            var solution = new Solution();
            var answer = solution.LongestPalindrome(s);

            Assert.Contains(answer, new[] { "bab", "aba" });
        }

        [Theory]
        [InlineData("cbbd")]
        public void Test2(string s)
        {
            var solution = new Solution();
            var answer = solution.LongestPalindrome(s);

            Assert.Contains(answer, new[] { "bb" });
        }

        [Theory]
        [InlineData("a")]
        public void Test3(string s)
        {
            var solution = new Solution();
            var answer = solution.LongestPalindrome(s);

            Assert.Contains(answer, new[] { "a" });
        }

        [Theory]
        [InlineData("ac")]
        public void Test4(string s)
        {
            var solution = new Solution();
            var answer = solution.LongestPalindrome(s);

            Assert.Contains(answer, new[] { "a" });
        }
    }
}
