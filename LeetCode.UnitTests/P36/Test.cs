using Xunit;
using LeetCode.P36;
using System.Collections.Generic;

namespace LeetCode.UnitTests.P36;

public class Test
{
    public static IEnumerable<object[]> Test1Data =>
        new List<object[]>
        {
            new object[]
            {
                new char[][]
                {
                    new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                    new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                    new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                    new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                    new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                    new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                    new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                    new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                    new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
                },
                true,
            },
            new object[]
            {
                new char[][]
                {
                    new char[] { '.', '.', '4', '.', '.', '.', '6', '3', '.' },
                    new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                    new char[] { '5', '.', '.', '.', '.', '.', '.', '9', '.' },
                    new char[] { '.', '.', '.', '5', '6', '.', '.', '.', '.' },
                    new char[] { '4', '.', '3', '.', '.', '.', '.', '.', '1' },
                    new char[] { '.', '.', '.', '7', '.', '.', '.', '.', '.' },
                    new char[] { '.', '.', '.', '5', '.', '.', '.', '.', '.' },
                    new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                    new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' }
                },
                false
            }
        };

    [Theory]
    [MemberData(nameof(Test1Data))]
    public void Test1(char[][] board, bool expected)
    {
        // Arrange
        var sut = new Solution();

        // Act
        var result = sut.IsValidSudoku(board);

        // Assert
        Assert.Equal(expected, result);
    }
}
