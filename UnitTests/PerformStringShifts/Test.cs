using Xunit;

namespace UnitTests.PerformStringShifts
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.PerformStringShifts.Solution();

            var result = solution.StringShift(
                "abc",
                new int[][] { 
                    new int[] { 0, 1 }, 
                    new int[] { 1, 2 }, 
                });
            Assert.Equal("cab", result);
        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.PerformStringShifts.Solution();

            var result = solution.StringShift(
                "abcdefg",
                new int[][] {
                    new int[] { 1, 1 },
                    new int[] { 1, 1 },
                    new int[] { 0, 2 },
                    new int[] { 1, 3 },
                });
            Assert.Equal("efgabcd", result);
        }
    }
}
