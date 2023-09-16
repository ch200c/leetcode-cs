using Xunit;

namespace LeetCode.UnitTests.P1008
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P1008.Solution();
            var result = solution.BstFromPreorder(new int[] { 8, 5, 1, 7, 10, 12 });
            Assert.Equal(8, result.val);
            Assert.Equal(5, result.left.val);
            Assert.Equal(10, result.right.val);
            Assert.Equal(1, result.left.left.val);
            Assert.Equal(7, result.left.right.val);
            Assert.Null(result.right.left);
            Assert.Equal(12, result.right.right.val);
        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.P1008.Solution();
            var result = solution.BstFromPreorder(new int[] { 3, 1, 2 });
            Assert.Equal(3, result.val);
            Assert.Equal(1, result.left.val);
            Assert.Equal(2, result.left.right.val);
        }
    }
}
