using System.Linq;
using Xunit;
using LeetCode.P238;

namespace LeetCode.UnitTests.P238;

public class Test
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
    [InlineData(new int[] { -1, 1, 0, -3, 3 }, new int[] { 0, 0, 9, 0, 0 })]
    public void Test1(int[] nums, int[] expected)
    {
        // Arrange
        var solution = new Solution();

        // Act
        var result = solution.ProductExceptSelf(nums);

        // Assert
        Assert.True(result.SequenceEqual(expected));
    }
}
