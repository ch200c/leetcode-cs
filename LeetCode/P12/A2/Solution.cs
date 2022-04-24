using System.Collections.Generic;
using System.Text;

namespace LeetCode.P12.A2;

public class Solution
{
    private readonly Dictionary<int, char> numberToSymbolByDescendingNumber = new()
    {
        { 1000, 'M' },
        { 500, 'D' },
        { 100, 'C' },
        { 50, 'L' },
        { 10, 'X' },
        { 5, 'V' },
        { 1, 'I' }
    };

    private readonly StringBuilder _stringBuilder = new(16);

    // Runtime: 130 ms, faster than 21.47% of C# online submissions for Integer to Roman.
    // Memory Usage: 38 MB, less than 44.68% of C# online submissions for Integer to Roman.
    public string IntToRoman(int num)
    {
        var consecutiveSymbolCount = 0;

        while (num != 0)
        {
            foreach (var (number, symbol) in numberToSymbolByDescendingNumber)
            {
                if (num - number >= 0)
                {
                    consecutiveSymbolCount = _stringBuilder.Length != 0 && symbol == _stringBuilder[^1]
                        ? consecutiveSymbolCount + 1
                        : 1;

                    _stringBuilder.Append(symbol);

                    if (consecutiveSymbolCount == 4)
                    {
                        var prefixSymbol = _stringBuilder.Length > 4
                            ? _stringBuilder[^5]
                            : _stringBuilder[^4];

                        ReplaceRepeatingSymbols(prefixSymbol, symbol);
                    }

                    num -= number;
                    break;
                }
            }
        }

        return _stringBuilder.ToString();
    }

    private void ReplaceRepeatingSymbols(char prefixSymbol, char symbol)
    {
        switch (prefixSymbol, symbol)
        {
            case ('D', 'C'):
                _stringBuilder.Remove(_stringBuilder.Length - 5, 5);
                _stringBuilder.Append("CM");
                break;
            case (_, 'C'):
                _stringBuilder.Remove(_stringBuilder.Length - 4, 4);
                _stringBuilder.Append("CD");
                break;
            case ('L', 'X'):
                _stringBuilder.Remove(_stringBuilder.Length - 5, 5);
                _stringBuilder.Append("XC");
                break;
            case (_, 'X'):
                _stringBuilder.Remove(_stringBuilder.Length - 4, 4);
                _stringBuilder.Append("XL");
                break;
            case ('V', 'I'):
                _stringBuilder.Remove(_stringBuilder.Length - 5, 5);
                _stringBuilder.Append("IX");
                break;
            case (_, 'I'):
                _stringBuilder.Remove(_stringBuilder.Length - 4, 4);
                _stringBuilder.Append("IV");
                break;
        }
    }
}