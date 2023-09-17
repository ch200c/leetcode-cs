using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.P49;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var orderedAnagrams = new ConcurrentDictionary<string, IList<string>>();

        Parallel.ForEach(strs, str =>
        {
            var key = new string(str.OrderBy(c => c).ToArray());

            orderedAnagrams.AddOrUpdate(
                key: key,
                addValue: new List<string>() { str },
                updateValueFactory: (_, values) =>
                {
                    values.Add(str);
                    return values;
                });
        });

        return (IList<IList<string>>)orderedAnagrams.Values;
    }
}
