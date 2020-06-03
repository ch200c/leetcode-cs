using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTests.P1029
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P1029.Solution();
            var result = solution.TwoCitySchedCost(new int[][] {
                new int[] { 10, 20},
                new int[] { 30, 200},
                new int[] { 400, 50},
                new int[] { 30, 20}});

            Assert.Equal(110, result);
        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.P1029.Solution();
            var result = solution.TwoCitySchedCost(new int[][] {
                new int[] { 259, 770},
                new int[] { 448, 54},
                new int[] { 926, 667},
                new int[] { 184, 139},
                new int[] { 840, 118},
                new int[] { 577, 469}});

            Assert.Equal(1859, result);
        }
    }
}
