using Xunit;

namespace UnitTests.P1046
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P1046.Solution();
            var result = solution.LastStoneWeight(new int[] { 2, 7, 4, 1, 8, 1 });
            Assert.Equal(1, result);
        }
    }
}
