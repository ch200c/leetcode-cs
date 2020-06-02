using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.P844.A1
{
    public class Solution
    {
        // Runtime: 72 ms (80.56 %)
        // Memory Usage: 22.7 MB
        public bool BackspaceCompare(string S, string T)
        {
            var sStack = RemoveBackspace(S);
            var tStack = RemoveBackspace(T);
            return sStack.SequenceEqual(tStack);
        }

        private Stack<char> RemoveBackspace(string input)
        {
            var outputStack = new Stack<char>();

            for (var i = 0; i < input.Length; ++i)
            {
                if (input[i] == '#')
                {
                    outputStack.TryPop(out _);
                }
                else
                {
                    outputStack.Push(input[i]);
                }
            }

            return outputStack;
        }
    }
}
