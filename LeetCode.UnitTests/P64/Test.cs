using Xunit;

namespace LeetCode.UnitTests.P64
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P64.Solution();
            var result = solution.MinPathSum(new int[][] {
                new int[] {1, 3, 1},
                new int[] {1, 5, 1},
                new int[] {4, 2, 1}});
            Assert.Equal(7, result);
        }
    }
}
