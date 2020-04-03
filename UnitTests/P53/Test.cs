using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTests.P53
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P53.Solution();
            var result = solution.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Assert.Equal(6, result);
        }
    }
}
