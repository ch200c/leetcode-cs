using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTests.P202
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P202.Solution();
            var result = solution.IsHappy(19);
            Assert.True(result);
        }
    }
}
