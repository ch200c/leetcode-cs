using Xunit;
using LeetCode.P125;

namespace LeetCode.UnitTests.P125;

public class Test
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    public void Test1(string s, bool expected)
    {
        // Arrange
        var solution = new Solution();

        // Act
        var result = solution.IsPalindrome(s);

        // Assert
        Assert.Equal(expected, result);
    }
}
