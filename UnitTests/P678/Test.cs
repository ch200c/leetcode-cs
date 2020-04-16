using Xunit;

namespace UnitTests.P678
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P678.Solution();
            var result = solution.CheckValidString("()");
            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.P678.Solution();
            var result = solution.CheckValidString("(*)");
            Assert.True(result);
        }

        [Fact]
        public void Test3()
        {
            var solution = new LeetCode.P678.Solution();
            var result = solution.CheckValidString("(*))");
            Assert.True(result);
        }
        [Fact]
        public void Test4()
        {
            var solution = new LeetCode.P678.Solution();
            var result = solution.CheckValidString("(())((())()()(*)(*()(())())())()()((()())((()))(*");
            Assert.False(result);
        }
    }
}
