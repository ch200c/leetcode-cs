using Xunit;
using System.Linq;
using LeetCode.P49;
using System.Collections.Generic;

namespace LeetCode.UnitTests.P49;

public class Test
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var sut = new Solution();

        // Act
        var result = sut.GroupAnagrams(
            new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });

        var expectedResult = new HashSet<string>[]
        {
            new HashSet<string>(){ "ate", "eat", "tea" },
            new HashSet<string>(){ "nat", "tan" },
            new HashSet<string>(){ "bat" }
        };

        var orderedResult = result
            .OrderByDescending(group => group.Count)
            .ToList();

        // Assert
        Assert.Equal(result.Count, expectedResult.Length);
        Assert.Subset(expectedResult[0], orderedResult[0].ToHashSet());
        Assert.Subset(expectedResult[1], orderedResult[1].ToHashSet());
        Assert.Subset(expectedResult[2], orderedResult[2].ToHashSet());
    }
}
