using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.P202
{
    public class Solution
    {
        public bool IsHappy(int n)
        {
            var history = new HashSet<int>();

            while (!history.Contains(n))
            {
                history.Add(n);
                var digits = ToDigits(n);
                n = digits.Sum((digit) => (int)Math.Pow(digit, 2));
            }

            return n == 1;
        }

        private List<int> ToDigits(int n)
        {
            var digits = new List<int>();

            while (n >= 10)
            {
                digits.Add(n % 10);
                n /= 10;
            }

            digits.Add(n);
            digits.Reverse();

            return digits;
        }
    }
}
