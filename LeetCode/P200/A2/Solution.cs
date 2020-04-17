using System.Collections.Generic;

namespace LeetCode.P200.A2
{
    public class Solution
    {
        // Runtime: 132 ms  (10.40 %)
        // Memory Usage: 30.8 MB
        public int NumIslands(char[][] grid)
        {
            var positionToCell = new Dictionary<(int, int), Cell>();

            for (var row = 0; row < grid.Length; ++row)
            {
                for (var col = 0; col < grid[row].Length; ++col)
                {
                    if (grid[row][col] != '1')
                    {
                        continue;
                    }

                    Cell cell;
                    if (positionToCell.ContainsKey((row, col)))
                    {
                        cell = positionToCell[(row, col)];
                    }
                    else
                    {
                        cell = new Cell();
                        positionToCell[(row, col)] = cell;
                    }

                    if (row - 1 >= 0 && grid[row - 1][col] == '1')
                    {
                        if (!positionToCell.ContainsKey((row - 1, col)))
                        {
                            cell.up = new Cell
                            {
                                down = cell,
                            };

                            positionToCell[(row - 1, col)] = cell.up;
                        }
                        else if (cell.up == null)
                        {
                            cell.up = positionToCell[(row - 1, col)];
                        }
                    }

                    if (row + 1 < grid.Length && grid[row + 1][col] == '1')
                    {
                        if (!positionToCell.ContainsKey((row + 1, col)))
                        {
                            cell.down = new Cell
                            {
                                up = cell,
                            };

                            positionToCell[(row + 1, col)] = cell.down;
                        }
                        else if (cell.down == null)
                        {
                            cell.down = positionToCell[(row + 1, col)];
                        }
                    }

                    if (col - 1 >= 0 && grid[row][col - 1] == '1')
                    {
                        if (!positionToCell.ContainsKey((row, col - 1)))
                        {
                            cell.left = new Cell
                            {
                                right = cell,
                            };

                            positionToCell[(row, col - 1)] = cell.left;
                        }

                        else if (cell.left == null)
                        {
                            cell.left = positionToCell[(row, col - 1)];
                        }
                    }

                    if (col + 1 < grid[row].Length && grid[row][col + 1] == '1')
                    {
                        if (!positionToCell.ContainsKey((row, col + 1)))
                        {
                            cell.right = new Cell
                            {
                                left = cell,
                            };

                            positionToCell[(row, col + 1)] = cell.right;
                        }
                        else if (cell.right == null)
                        {
                            cell.right = positionToCell[(row, col + 1)];
                        }
                    }
                }
            }

            var islandIndex = 0;
            foreach (var key in positionToCell.Keys)
            {
                if (positionToCell[key].islandIndex == -1)
                {
                    TraverseCell(positionToCell[key], islandIndex);
                    ++islandIndex;
                }
            }

            return islandIndex;
        }

        private void TraverseCell(Cell cell, int islandIndex)
        {
            if (cell == null || cell.islandIndex != -1)
            {
                return;
            }

            cell.islandIndex = islandIndex;

            TraverseCell(cell.up, islandIndex);
            TraverseCell(cell.left, islandIndex);
            TraverseCell(cell.right, islandIndex);
            TraverseCell(cell.down, islandIndex);
        }
    }
}
