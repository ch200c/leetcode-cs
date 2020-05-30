using Xunit;

namespace UnitTests.P394
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P394.Solution();
            var result = solution.DecodeString("3[a]2[bc]");
            Assert.Equal("aaabcbc", result);
        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.P394.Solution();
            var result = solution.DecodeString("3[a2[c]]");
            Assert.Equal("accaccacc", result);
        }

        [Fact]
        public void Test3()
        {
            var solution = new LeetCode.P394.Solution();
            var result = solution.DecodeString("2[abc]3[cd]ef");
            Assert.Equal("abcabccdcdcdef", result);
        }
    }
}
