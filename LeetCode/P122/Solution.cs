namespace LeetCode.P122
{
    public class Solution
    {
        // Runtime: 144 ms (24.51 %)
        // Memory Usage: 25.1 MB
        public int MaxProfit(int[] prices)
        {
            var totalProfit = 0;

            for (var i = 1; i < prices.Length; ++i)
            {
                if (prices[i] > prices[i - 1])
                {
                    // Assume profit when later price is higher
                    totalProfit += prices[i] - prices[i - 1];
                }
            }

            return totalProfit;
        }
    }
}
