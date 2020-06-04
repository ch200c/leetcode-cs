using System;
using Xunit;
using System.Linq;

namespace UnitTests.P344
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P344.Solution();
            var input = "hello".ToCharArray();
            solution.ReverseString(input);
            Assert.Equal("hello".ToCharArray().Reverse(), input);
        }
    }
}
