using Xunit;

namespace UnitTests.LeftmostColumnWithAtLeastAOne
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.LeftmostColumnWithAtLeastAOne.Solution();
            var result = solution.LeftMostColumnWithOne(
                new LeetCode.LeftmostColumnWithAtLeastAOne.BinaryMatrix(
                    new int[][] {
                        new int[]{ 0, 0},
                        new int[]{ 1, 1}
                    }));

            Assert.Equal(0, result);
        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.LeftmostColumnWithAtLeastAOne.Solution();
            var result = solution.LeftMostColumnWithOne(
                new LeetCode.LeftmostColumnWithAtLeastAOne.BinaryMatrix(
                    new int[][] {
                        new int[]{ 0, 0},
                        new int[]{ 0, 1}
                    }));

            Assert.Equal(1, result);
        }


        [Fact]
        public void Test3()
        {
            var solution = new LeetCode.LeftmostColumnWithAtLeastAOne.Solution();
            var result = solution.LeftMostColumnWithOne(
                new LeetCode.LeftmostColumnWithAtLeastAOne.BinaryMatrix(
                    new int[][] {
                        new int[]{ 0, 0},
                        new int[]{ 0, 0}
                    }));

            Assert.Equal(-1, result);
        }

        [Fact]
        public void Test4()
        {
            var solution = new LeetCode.LeftmostColumnWithAtLeastAOne.Solution();
            var result = solution.LeftMostColumnWithOne(
                new LeetCode.LeftmostColumnWithAtLeastAOne.BinaryMatrix(
                    new int[][] {
                        new int[]{ 0, 0, 0, 1},
                        new int[]{ 0, 0, 1, 1},
                        new int[]{ 0, 1, 1, 1}
                    })) ;

            Assert.Equal(1, result);
        }
    }
}
