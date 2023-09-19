using Xunit;
using LeetCode.P167;

namespace LeetCode.UnitTests.P167;

public class Test
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
    [InlineData(new int[] { 2, 3, 4 }, 6, new int[] { 1, 3 })]
    [InlineData(new int[] { -1, 0 }, -1, new int[] { 1, 2 })]
    public void Test1(int[] nums, int target, int[] expected)
    {
        // Arrange
        var sut = new Solution();

        // Act
        var result = sut.TwoSum(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }
}
