using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.P12.A1;

public class Solution
{
    private readonly Dictionary<int, char> numberToSymbol = new()
    {
        { 1, 'I' },
        { 5, 'V' },
        { 10, 'X' },
        { 50, 'L' },
        { 100, 'C' },
        { 500, 'D' },
        { 1000, 'M' },
    };

    // Runtime: 144 ms (11.67%)
    // Memory Usage: 38.2 MB (28.63%)
    public string IntToRoman(int num)
    {
        var numberToSymbolByDescendingNumber = numberToSymbol.OrderByDescending(numberAndSymbol => numberAndSymbol.Key);

        var stringBuilder = new StringBuilder();

        while (num != 0)
        {
            foreach (var (number, symbol) in numberToSymbolByDescendingNumber)
            {
                if (num - number >= 0)
                {
                    stringBuilder.Append(symbol);
                    num -= number;
                    break;
                }
            }
        }

        stringBuilder.Replace("DCCCC", "CM");
        stringBuilder.Replace("CCCC", "CD");

        stringBuilder.Replace("LXXXX", "XC");
        stringBuilder.Replace("XXXX", "XL");

        stringBuilder.Replace("VIIII", "IX");
        stringBuilder.Replace("IIII", "IV");

        return stringBuilder.ToString();
    }
}