using System.Linq;
using Xunit;

namespace UnitTests.P238
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P238.Solution();
            var result = solution.ProductExceptSelf(new int[] { 1, 2, 3, 4 });
            Assert.True(result.SequenceEqual(new int[] { 24, 12, 8, 6 }));
        }
    }
}
