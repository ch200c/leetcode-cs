using LeetCode.P217;
using Xunit;

namespace LeetCode.UnitTests.P217;

public class Test
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    public void Test1(int[] nums, bool expected)
    {
        // Arrange
        var sut = new Solution();

        // Act
        var result = sut.ContainsDuplicate(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}
