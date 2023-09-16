using Xunit;

namespace LeetCode.UnitTests.P12.A2;

public class Test
{
    [Fact]
    public void Test1()
    {
        var solution = new LeetCode.P12.A2.Solution();
        var result = solution.IntToRoman(3);

        Assert.Equal("III", result);
    }

    [Fact]
    public void Test2()
    {
        var solution = new LeetCode.P12.A2.Solution();
        var result = solution.IntToRoman(58);

        Assert.Equal("LVIII", result);
    }

    [Fact]
    public void Test3()
    {
        var solution = new LeetCode.P12.A2.Solution();
        var result = solution.IntToRoman(1994);

        Assert.Equal("MCMXCIV", result);
    }

    [Fact]
    public void Test4()
    {
        var solution = new LeetCode.P12.A2.Solution();
        var result = solution.IntToRoman(4);

        Assert.Equal("IV", result);
    }

    [Fact]
    public void Test5()
    {
        var solution = new LeetCode.P12.A2.Solution();
        var result = solution.IntToRoman(9);

        Assert.Equal("IX", result);
    }
}