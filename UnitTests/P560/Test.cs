using Xunit;

namespace UnitTests.P560
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P560.Solution();
            var result = solution.SubarraySum(
                new int[] { 1, 1, 1 }, 2);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.P560.Solution();
            var result = solution.SubarraySum(
                new int[] { 1, 2, 1, 2, 1 }, 3);

            Assert.Equal(4, result);
        }
    }
}
