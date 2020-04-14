using Xunit;

namespace UnitTests.CountingElements
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.CountingElements.Solution();
            var result = solution.CountElements(new int[] { 1, 2, 3 });
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.CountingElements.Solution();
            var result = solution.CountElements(new int[] { 1, 3, 2, 3, 5, 0 });
            Assert.Equal(3, result);
        }

        [Fact]
        public void Test3()
        {
            var solution = new LeetCode.CountingElements.Solution();
            var result = solution.CountElements(new int[] { 1, 1, 2, 2 });
            Assert.Equal(2, result);
        }
    }
}
