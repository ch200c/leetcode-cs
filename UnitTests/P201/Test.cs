using Xunit;

namespace UnitTests.P201
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P201.Solution();
            var result = solution.RangeBitwiseAnd(5, 7);
            Assert.Equal(4, result);
        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.P201.Solution();
            var result = solution.RangeBitwiseAnd(0, 1);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test3()
        {
            var solution = new LeetCode.P201.Solution();
            var result = solution.RangeBitwiseAnd(1, 2);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test4()
        {
            var solution = new LeetCode.P201.Solution();
            var result = solution.RangeBitwiseAnd(1, 3);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test5()
        {
            var solution = new LeetCode.P201.Solution();
            var result = solution.RangeBitwiseAnd(2, 6);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test6()
        {
            var solution = new LeetCode.P201.Solution();
            var result = solution.RangeBitwiseAnd(3, 3);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Test7()
        {
            var solution = new LeetCode.P201.Solution();
            var result = solution.RangeBitwiseAnd(6, 7);
            Assert.Equal(6, result);
        }
    }
}
