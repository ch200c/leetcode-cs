using System;

namespace LeetCode.P64
{
    public class Solution
    {
        // Runtime: 92 ms (96.20 %)
        // Memory Usage: 26.2 MB
        public int MinPathSum(int[][] grid)
        {
            for (var row = 0; row < grid.Length; ++row)
            {
                for (var col = 0; col < grid[0].Length; ++col)
                {
                    if (row == 0 && col == 0)
                    {
                        continue;
                    }

                    var previousRow = row > 0 ? grid[row - 1][col] : int.MaxValue;
                    var previousCol = col > 0 ? grid[row][col - 1] : int.MaxValue;

                    grid[row][col] += Math.Min(previousRow, previousCol);
                }
            }

            return grid[grid.Length - 1][grid[0].Length - 1];
        }
    }
}
