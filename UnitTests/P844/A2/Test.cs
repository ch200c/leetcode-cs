using Xunit;

namespace UnitTests.P844.A2
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P844.A2.Solution();
            var result = solution.BackspaceCompare("ab#c", "ad#c");
            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.P844.A2.Solution();
            var result = solution.BackspaceCompare("ab##","c#d#");
            Assert.True(result);
        }

        [Fact]
        public void Test3()
        {
            var solution = new LeetCode.P844.A2.Solution();
            var result = solution.BackspaceCompare("a##c",  "#a#c");
            Assert.True(result);
        }

        [Fact]
        public void Test4()
        {
            var solution = new LeetCode.P844.A2.Solution();
            var result = solution.BackspaceCompare("a#c","b");
            Assert.False(result);
        }

        [Fact]
        public void Test5()
        {
            var solution = new LeetCode.P844.A2.Solution();
            var result = solution.BackspaceCompare("rjhbpvh", "rjh#bpvh");
            Assert.False(result);
        }

        [Fact]
        public void Test6()
        {
            var solution = new LeetCode.P844.A2.Solution();
            var result = solution.BackspaceCompare("isfcow#", "isfco#w#");
            Assert.False(result);
        }
    }
}
