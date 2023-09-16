using LeetCode.P1;
using Xunit;

namespace LeetCode.UnitTests.P1;

public class Test
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new[] { 0, 1 })]

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
