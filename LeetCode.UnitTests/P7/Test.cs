using Xunit;

namespace LeetCode.UnitTests.P7
{
    public class Test
    {
        [Theory]
        [InlineData(123)]
        public void Test1(int x)
        {
            var solution = new LeetCode.P7.Solution();
            var answer = solution.Reverse(x);

            Assert.Equal(321, answer);
        }

        [Theory]
        [InlineData(-123)]
        public void Test2(int x)
        {
            var solution = new LeetCode.P7.Solution();
            var answer = solution.Reverse(x);

            Assert.Equal(-321, answer);
        }

        [Theory]
        [InlineData(120)]
        public void Test3(int x)
        {
            var solution = new LeetCode.P7.Solution();
            var answer = solution.Reverse(x);

            Assert.Equal(21, answer);
        }

        [Theory]
        [InlineData(0)]
        public void Test4(int x)
        {
            var solution = new LeetCode.P7.Solution();
            var answer = solution.Reverse(x);

            Assert.Equal(0, answer);
        }
    }
}
