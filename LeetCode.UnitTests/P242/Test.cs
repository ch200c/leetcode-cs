using LeetCode.P242;
using Xunit;

namespace LeetCode.UnitTests.P242;

public class Test
{
    private readonly Solution _sut;

    public Test()
    {
        _sut = new Solution();
    }

    [Fact]
    public void Test1()
    {
        // Act
        var result = _sut.IsAnagram("anagram", "nagaram");

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test2()
    {
        // Act
        var result = _sut.IsAnagram("rat", "car");

        // Assert
        Assert.False(result);
    }
}
