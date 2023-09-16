using System;
using System.Linq;
using Xunit;

namespace LeetCode.UnitTests.P283
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P283.Solution();
            var input = new int[] { 0, 1, 0, 3, 12 };
            solution.MoveZeroes(input);
            Assert.True(input.SequenceEqual(new int[] { 1, 3, 12, 0, 0 }));
        }
    }
}
