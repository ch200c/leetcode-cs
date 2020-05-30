using System.Collections.Generic;

namespace LeetCode.P394
{
    public class Solution
    {
        // Runtime: 148 ms (5.59%)
        // Memory Usage: 22.9 MB 
        public string DecodeString(string s)
        {
            var decodedString = "";
            var multiplierString = "";
            var encodedParts = new Stack<string>();
            var multipliers = new Stack<int>();

            for (var i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    multiplierString += s[i];
                }
                else
                {
                    if (multiplierString != "")
                    {
                        var multiplier = int.Parse(multiplierString);
                        multipliers.Push(multiplier);
                        multiplierString = "";
                    }

                    if (s[i] == '[')
                    {
                        encodedParts.Push(decodedString);
                        decodedString = "";
                    }
                    else if (s[i] == ']')
                    {
                        var lastDecodedPart = decodedString;

                        decodedString = encodedParts.Pop();

                        for (var j = multipliers.Pop(); j > 0; j--)
                        {
                            decodedString += lastDecodedPart;
                        }
                    }
                    else
                    {
                        decodedString += s[i];
                    }
                }
            }

            return decodedString;
        }
    }
}
