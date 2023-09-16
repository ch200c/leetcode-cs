using LeetCode.P217;
using Xunit;

namespace LeetCode.UnitTests.P217;

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
        var result = _sut.ContainsDuplicate(new int[] { 1, 2, 3, 1 });

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test2()
    {
        // Act
        var result = _sut.ContainsDuplicate(new int[] { 1, 2, 3, 4 });

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Test3()
    {
        // Act
        var result = _sut.ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });

        // Assert
        Assert.True(result);
    }
}
