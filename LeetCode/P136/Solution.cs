using System.Collections.Generic;
using System.Linq;

namespace LeetCode.P136
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            var duplicates = new HashSet<int>();

            foreach (var num in nums)
            {
                if (duplicates.Contains(num))
                {
                    duplicates.Remove(num);
                }
                else
                {
                    duplicates.Add(num);
                }
            }

            return duplicates.First();
        }
    }
}
