using Xunit;

namespace UnitTests.P1
{
    public class Test
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9)]
        public void Test1(int[] nums, int target)
        {
            var solution = new LeetCode.P1.Solution();
            var answer = solution.TwoSum(nums, target);

            Assert.Equal(new[] { 0, 1 }, answer);
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 4 }, 6)]
        public void Test2(int[] nums, int target)
        {
            var solution = new LeetCode.P1.Solution();
            var answer = solution.TwoSum(nums, target);

            Assert.Equal(new[] { 1, 2 }, answer);
        }

        [Theory]
        [InlineData(new int[] { 3, 3 }, 6)]
        public void Test3(int[] nums, int target)
        {
            var solution = new LeetCode.P1.Solution();
            var answer = solution.TwoSum(nums, target);

            Assert.Equal(new[] { 0, 1 }, answer);
        }
    }
}
