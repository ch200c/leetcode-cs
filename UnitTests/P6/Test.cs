using Xunit;

namespace UnitTests.P6;

public class Test
{
    [Fact]
    public void Test1()
    {
        var solution = new LeetCode.P6.Solution();
        var result = solution.Convert("PAYPALISHIRING", 3);

        Assert.Equal("PAHNAPLSIIGYIR", result);
    }

    [Fact]
    public void Test2()
    {
        var solution = new LeetCode.P6.Solution();
        var result = solution.Convert("PAYPALISHIRING", 4);

        Assert.Equal("PINALSIGYAHRPI", result);
    }

    [Fact]
    public void Test3()
    {
        var solution = new LeetCode.P6.Solution();
        var result = solution.Convert("A", 1);

        Assert.Equal("A", result);
    }

    [Fact]
    public void Test4()
    {
        var solution = new LeetCode.P6.Solution();
        var result = solution.Convert("AB", 1);

        Assert.Equal("AB", result);
    }

    [Fact]
    public void Test5()
    {
        var solution = new LeetCode.P6.Solution();
        var result = solution.Convert("ABC", 2);

        Assert.Equal("ACB", result);
    }

    [Fact]
    public void Test6()
    {
        var solution = new LeetCode.P6.Solution();
        var result = solution.Convert("ABC", 1);

        Assert.Equal("ABC", result);
    }

    [Fact]
    public void Test7()
    {
        var solution = new LeetCode.P6.Solution();
        var result = solution.Convert("ABCD", 2);

        Assert.Equal("ACBD", result);
    }
}