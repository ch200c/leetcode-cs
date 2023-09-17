using LeetCode.P347;
using System.Linq;
using Xunit;

namespace LeetCode.UnitTests.P347;

public class Test
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1, 2, 2, 3 }, 2, new int[] { 1, 2 })]
    [InlineData(new int[] { 1 }, 1, new int[] { 1 })]
    public void Test1(int[] nums, int k, int[] expected)
    {
        // Arrange
        var sut = new Solution();

        // Act
        var result = sut.TopKFrequent(nums, k);

        // Assert
        Assert.Subset(expected.ToHashSet(), result.ToHashSet());
    }
}
