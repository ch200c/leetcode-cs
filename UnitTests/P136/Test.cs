using Xunit;

namespace UnitTests.P136
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P136.Solution();
            var result = solution.SingleNumber(new int[] { 2, 2, 1 });
            Assert.Equal(1, result);
        }
    }
}
