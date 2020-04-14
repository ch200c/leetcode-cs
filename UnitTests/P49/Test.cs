using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace UnitTests.P49
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P49.Solution();
            var result = solution.GroupAnagrams(
                new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });

            var expectedResult = new List<IList<string>>() {
                new List<string>() { "ate", "eat", "tea" },
                new List<string>() { "nat", "tan" },
                new List<string>() { "bat" } };

            // TODO
            Assert.Subset(expectedResult[0].ToHashSet(), result[0].ToHashSet());
            Assert.Subset(expectedResult[1].ToHashSet(), result[1].ToHashSet());
            Assert.Subset(expectedResult[2].ToHashSet(), result[2].ToHashSet());
        }
    }
}
