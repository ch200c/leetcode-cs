using Xunit;

namespace UnitTests.P525
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P525.Solution();
            var result = solution.FindMaxLength(new int[] { 0, 1 });
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.P525.Solution();
            var result = solution.FindMaxLength(new int[] { 0, 1, 0 });
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test3()
        {
            var solution = new LeetCode.P525.Solution();
            var result = solution.FindMaxLength(new int[] { 0, 0, 1, 0, 0, 0, 1, 1 });
            Assert.Equal(6, result);
        }

        [Fact]
        public void Test4()
        {
            var solution = new LeetCode.P525.Solution();
            var result = solution.FindMaxLength(new int[] { 0, 1, 1, 0, 1, 1, 1, 0 });
            Assert.Equal(4, result);
        }
    }
}
