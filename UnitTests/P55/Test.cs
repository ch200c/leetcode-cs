using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTests.P55
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P55.Solution();
            var result = solution.CanJump(new int[] { 2, 3, 1, 1, 4 });
            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.P55.Solution();
            var result = solution.CanJump(new int[] { 3, 2, 1, 0, 4 });
            Assert.False(result);
        }

        [Fact]
        public void Test3()
        {
            var solution = new LeetCode.P55.Solution();
            var result = solution.CanJump(new int[] { 0 });
            Assert.True(result);
        }

        [Fact]
        public void Test4()
        {
            var solution = new LeetCode.P55.Solution();
            var result = solution.CanJump(new int[] { 2, 0, 0 });
            Assert.True(result);
        }
    }
}
