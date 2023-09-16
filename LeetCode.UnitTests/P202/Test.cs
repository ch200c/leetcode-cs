using Xunit;

namespace LeetCode.UnitTests.P202
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P202.Solution();
            var result = solution.IsHappy(19);
            Assert.True(result);
        }
    }
}
