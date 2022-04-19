using Xunit;

namespace UnitTests.P4
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P4.Solution();
            var result = solution.FindMedianSortedArrays(
                new int[]{ 1, 3},
                new int[]{ 2 });

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.P4.Solution();
            var result = solution.FindMedianSortedArrays(
                new int[] { 1, 2 },
                new int[] { 3, 4 });

            Assert.Equal(2.5, result);
        }
    }
}
