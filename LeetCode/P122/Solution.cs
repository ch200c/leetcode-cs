using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.P122
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            var totalProfit = 0;

            for (var i = 1; i < prices.Length; ++i)
            {
                if (prices[i] > prices[i - 1])
                {
                    totalProfit += prices[i] - prices[i - 1];
                }
            }

            return totalProfit;
        }
    }
}
