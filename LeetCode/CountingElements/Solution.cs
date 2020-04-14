using System.Linq;

namespace LeetCode.CountingElements
{
    public class Solution
    {
        // Runtime: 92 ms
        // Memory Usage: 24.1 MB
        public int CountElements(int[] arr)
        {
            var uniques = arr.ToHashSet();
            return arr.Count((x) => uniques.Contains(x + 1));
        }
    }
}
