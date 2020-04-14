using System.Collections.Generic;
using System.Linq;

namespace LeetCode.P49
{
    public class Solution
    {
        // Runtime: 312 ms (58.43 %)
        // Memory Usage: 38.8 MB
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var sortedStringToAnagrams = new Dictionary<string, List<string>>();

            for (var i = 0; i < strs.Length; ++i)
            {
                if (sortedStringToAnagrams.ContainsKey(strs[i]))
                {
                    sortedStringToAnagrams[strs[i]].Add(strs[i]);
                }
                else
                {
                    var sortedString = new string(strs[i].OrderBy(c => c).ToArray());
                    if (sortedStringToAnagrams.ContainsKey(sortedString))
                    {
                        sortedStringToAnagrams[sortedString].Add(strs[i]);
                    }
                    else
                    {
                        sortedStringToAnagrams[sortedString] = new List<string>() { strs[i] };
                    }
                }
            }

            var groups = new List<IList<string>>();

            foreach (var key in sortedStringToAnagrams.Keys)
            {
                groups.Add(sortedStringToAnagrams[key]);
            }

            return groups;
        }
    }
}
