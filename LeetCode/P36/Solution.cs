using System.Collections.Generic;
using System.Linq;

namespace LeetCode.P36;

public enum SubGrid
{
    TopLeft,
    TopCenter,
    TopRight,
    MiddleLeft,
    MiddleCenter,
    MiddleRight,
    BottomLeft,
    BottomCenter,
    BottomRight
}

public class Solution
{
    private readonly List<List<char>> _rows;
    private readonly List<List<char>> _columns;
    private readonly Dictionary<SubGrid, List<char>> _subGrids;

    public Solution()
    {
        _rows = new List<List<char>>();
        _columns = new List<List<char>>();

        for (var i = 0; i < 9; i++)
        {
            _rows.Add(new List<char>());
            _columns.Add(new List<char>());
        }

        _subGrids = new Dictionary<SubGrid, List<char>>()
        {
            { SubGrid.TopLeft, new List<char>() },
            { SubGrid.TopCenter, new List<char>() },
            { SubGrid.TopRight, new List<char>() },
            { SubGrid.MiddleLeft, new List<char>() },
            { SubGrid.MiddleCenter, new List<char>() },
            { SubGrid.MiddleRight, new List<char>() },
            { SubGrid.BottomLeft, new List<char>() },
            { SubGrid.BottomCenter, new List<char>() },
            { SubGrid.BottomRight, new List<char>() },
        };
    }

    public bool IsValidSudoku(char[][] board)
    {
        for (var row = 0; row < 9; row++)
        {
            for (var column = 0; column < 9; column++)
            {
                if (board[row][column] != '.')
                {
                    _rows[row].Add(board[row][column]);
                    _columns[column].Add(board[row][column]);

                    var subGrid = GetSubGrid(row, column);
                    _subGrids[subGrid].Add(board[row][column]);
                }
            }
        }

        for (var i = 0; i < 9; i++)
        {
            if (_rows[i].ToHashSet().Count != _rows[i].Count ||
                _columns[i].ToHashSet().Count != _columns[i].Count)
            {
                return false;
            }
        }

        return _subGrids[SubGrid.TopLeft].ToHashSet().Count == _subGrids[SubGrid.TopLeft].Count &&
            _subGrids[SubGrid.TopCenter].ToHashSet().Count == _subGrids[SubGrid.TopCenter].Count &&
            _subGrids[SubGrid.TopRight].ToHashSet().Count == _subGrids[SubGrid.TopRight].Count &&
            _subGrids[SubGrid.MiddleLeft].ToHashSet().Count == _subGrids[SubGrid.MiddleLeft].Count &&
            _subGrids[SubGrid.MiddleCenter].ToHashSet().Count == _subGrids[SubGrid.MiddleCenter].Count &&
            _subGrids[SubGrid.MiddleRight].ToHashSet().Count == _subGrids[SubGrid.MiddleRight].Count &&
            _subGrids[SubGrid.BottomLeft].ToHashSet().Count == _subGrids[SubGrid.BottomLeft].Count &&
            _subGrids[SubGrid.BottomCenter].ToHashSet().Count == _subGrids[SubGrid.BottomCenter].Count &&
            _subGrids[SubGrid.BottomRight].ToHashSet().Count == _subGrids[SubGrid.BottomRight].Count;
    }

    private static SubGrid GetSubGrid(int row, int column)
    {
        if (row <= 2 && column <= 2)
        {
            return SubGrid.TopLeft;
        }
        else if (row > 2 && row <= 5 && column <= 2)
        {
            return SubGrid.MiddleLeft;
        }
        else if (row > 5 && column <= 2)
        {
            return SubGrid.BottomLeft;
        }
        else if (row <= 2 && column > 2 && column <= 5)
        {
            return SubGrid.TopCenter;
        }
        else if (row > 2 && row <= 5 && column > 2 && column <= 5)
        {
            return SubGrid.MiddleCenter;
        }
        else if (row > 5 && column > 2 && column <= 5)
        {
            return SubGrid.BottomCenter;
        }
        else if (row <= 2 && column > 5)
        {
            return SubGrid.TopRight;
        }
        else if (row > 2 && row <= 5 && column > 5)
        {
            return SubGrid.MiddleRight;
        }
        else
        {
            return SubGrid.BottomRight;
        }
    }
}