using System;
using System.Linq;

namespace LeetCode.P1029
{
    public class Solution
    {
        // Runtime: 100 ms (38.24 %)
        // Memory Usage: 24.6 MB
        public int TwoCitySchedCost(int[][] costs)
        {
            // Ascending B-A cost sort.
            // Elements in the array will start with largest A and end with largest B cost.
            Array.Sort(costs, (a, b) => (a[1] - a[0]).CompareTo(b[1] - b[0]));

            var cost = costs.TakeLast(costs.Length / 2).Aggregate(0, (total, next) => total + next[0]);
            cost = costs.Take(costs.Length / 2).Aggregate(cost, (total, next) => total + next[1]);

            return cost;
        }
    }
}
