using Xunit;

namespace LeetCode.UnitTests.P200.A2
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P200.A2.Solution();
            var result = solution.NumIslands(new char[][] { 
                new char[] { '1','1','1','1','0' },
                new char[] { '1','1','0','1','0' },
                new char[] { '1','1','0','0','0' },
                new char[] { '0','0','0','0','0' }});
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.P200.A2.Solution();
            var result = solution.NumIslands(new char[][] {
                new char[] { '1','1','0','0','0' },
                new char[] { '1','1','0','0','0' },
                new char[] { '0','0','1','0','0' },
                new char[] { '0','0','0','1','1' }});
            Assert.Equal(3, result);
        }

        [Fact]
        public void Test3()
        {
            var solution = new LeetCode.P200.A2.Solution();
            var result = solution.NumIslands(new char[][] {
                new char[] { '1','1','1' },
                new char[] { '0','1','0'},
                new char[] { '1','1','1' }});
            Assert.Equal(1, result);
        }
    }
}
