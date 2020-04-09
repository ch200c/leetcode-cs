using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.P844.A1
{
    public class Solution
    {
        public bool BackspaceCompare(string S, string T)
        {
            var sStack = new Stack<char>();
            for (var i = 0; i < S.Length; ++i)
            {
                if (S[i]=='#')
                {
                    sStack.TryPop(out _);
                }
                else
                {
                    sStack.Push(S[i]);
                }
            }

            var tStack = new Stack<char>();
            for (var i = 0; i < T.Length; ++i)
            {
                if (T[i] == '#')
                {
                    tStack.TryPop(out _);
                }
                else
                {
                    tStack.Push(T[i]);
                }
            }

            return sStack.SequenceEqual(tStack);
        }
    }
}
