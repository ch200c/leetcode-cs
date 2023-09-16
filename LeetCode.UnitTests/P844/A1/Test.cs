using Xunit;

namespace LeetCode.UnitTests.P844.A1
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P844.A1.Solution();
            var result = solution.BackspaceCompare("ab#c", "ad#c");
            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.P844.A1.Solution();
            var result = solution.BackspaceCompare("ab##","c#d#");
            Assert.True(result);
        }

        [Fact]
        public void Test3()
        {
            var solution = new LeetCode.P844.A1.Solution();
            var result = solution.BackspaceCompare("a##c",  "#a#c");
            Assert.True(result);
        }

        [Fact]
        public void Test4()
        {
            var solution = new LeetCode.P844.A1.Solution();
            var result = solution.BackspaceCompare("a#c","b");
            Assert.False(result);
        }
    }
}
