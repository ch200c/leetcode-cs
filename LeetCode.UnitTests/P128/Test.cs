using Xunit;
using LeetCode.P128;

namespace LeetCode.UnitTests.P128;

public class Test
{
    [Theory]
    [InlineData(new int[] { 100, 4, 200, 1, 3, 2 }, 4)]
    [InlineData(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9)]
    [InlineData(new int[] { }, 0)]
    public void Test1(int[] nums, int expected)
    {
        // Arrange
        var solution = new Solution();

        // Act
        var result = solution.LongestConsecutive(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}
