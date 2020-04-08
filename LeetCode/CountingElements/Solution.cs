using System.Linq;

namespace LeetCode.CountingElements
{
    public class Solution
    {
        public int CountElements(int[] arr)
        {
            var uniques = arr.ToHashSet();
            return arr.Count((x) => uniques.Contains(x + 1));
        }
    }
}
