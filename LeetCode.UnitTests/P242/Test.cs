using LeetCode.P242;
using Xunit;

namespace LeetCode.UnitTests.P242;

public class Test
{
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    public void Test1(string s, string t, bool expected)
    {
        // Arrange
        var sut = new Solution();

        // Act
        var result = sut.IsAnagram(s, t);

        // Assert
        Assert.Equal(expected, result);
    }
}
