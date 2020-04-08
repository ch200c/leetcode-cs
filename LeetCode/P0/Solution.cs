using System.Linq;

namespace LeetCode.P0
{
    public class Solution
    {
        public int CountElements(int[] arr)
        {
            var arrayCopy = arr.ToList();
            var count = 0;
            for (var i = 0; i < arr.Length; ++i)
            {
                if (arrayCopy.Contains(arr[i] + 1))
                {
                    ++count;
                }
            }

            return count;
        }
    }
}
