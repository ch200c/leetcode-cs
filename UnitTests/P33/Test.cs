using Xunit;

namespace UnitTests.P33
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P33.Solution();
            var result = solution.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0);
            Assert.Equal(4,result);
        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.P33.Solution();
            var result = solution.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3);
            Assert.Equal( -1,result);
        }

        [Fact]
        public void Test3()
        {
            var solution = new LeetCode.P33.Solution();
            var result = solution.Search(new int[] { 1 }, 1);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test4()
        {
            var solution = new LeetCode.P33.Solution();
            var result = solution.Search(new int[] { 1,3 }, 1);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test5()
        {
            var solution = new LeetCode.P33.Solution();
            var result = solution.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 5);
            Assert.Equal(1, result);
        }
    }
}
