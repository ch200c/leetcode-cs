using System.Collections.Generic;

namespace LeetCode.LeftmostColumnWithAtLeastAOne
{
    public class BinaryMatrix
    {
        private int[][] _grid;
        public BinaryMatrix(int[][] grid)
        {
            _grid = grid;
        }
        public int Get(int x, int y)
        {
            return _grid[x][y];
        }
        public IList<int> Dimensions()
        {
            return new List<int>() { _grid.Length, _grid[0].Length };
        }
    }
}
