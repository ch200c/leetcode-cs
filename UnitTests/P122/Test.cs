using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTests.P122
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P122.Solution();
            var result = solution.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            Assert.Equal(7, result);
        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.P122.Solution();
            var result = solution.MaxProfit(new int[] { 1, 2, 3, 4, 5 });
            Assert.Equal(4, result);
        }

        [Fact]
        public void Test3()
        {
            var solution = new LeetCode.P122.Solution();
            var result = solution.MaxProfit(new int[] { 7, 6, 4, 3, 1 });
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test4()
        {
            var solution = new LeetCode.P122.Solution();
            var result = solution.MaxProfit(new int[] { 2, 4, 1 });
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test5()
        {
            var solution = new LeetCode.P122.Solution();
            var result = solution.MaxProfit(new int[] { 6, 1, 3, 2, 4, 7 });
            Assert.Equal(7, result);
        }
    }
}
