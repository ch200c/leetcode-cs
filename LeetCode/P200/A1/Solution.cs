namespace LeetCode.P200.A1
{
    public class Solution
    {
        private char[][] _grid;

        // Runtime: 104 ms (89.90 %)
        // Memory Usage: 27.8 MB
        public int NumIslands(char[][] grid)
        {
            _grid = grid;

            var islandCount = 0;

            for (var row = 0; row < grid.Length; ++row)
            {
                for (var col = 0; col < grid[row].Length; ++col)
                {
                    if (grid[row][col] == '1')
                    {
                        ++islandCount;
                        FillWithWater(row, col);
                    }
                }
            }

            return islandCount;
        }

        private void FillWithWater(int row, int col)
        {
            if (row < 0 || row > _grid.Length - 1 ||
                col < 0 || col > _grid[row].Length - 1 || _grid[row][col] == '0')
            {
                return;
            }

            _grid[row][col] = '0';
            FillWithWater(row + 1, col);
            FillWithWater(row - 1, col);
            FillWithWater(row, col + 1);
            FillWithWater(row, col - 1);
        }
    }
}
