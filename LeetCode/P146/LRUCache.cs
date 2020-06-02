using System.Collections.Generic;

namespace LeetCode.P146
{
    // Runtime: 404 ms (21.83 %)
    // Memory Usage: 50.3 MB
    public class LRUCache
    {
        readonly private int capacity;
        readonly private Dictionary<int, int> cache;
        readonly private LinkedList<int> history;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            cache = new Dictionary<int, int>();
            history = new LinkedList<int>();
        }

        public int Get(int key)
        {
            if (cache.ContainsKey(key))
            {
                history.Remove(key);
                history.AddLast(key);
                return cache[key];
            }
            else
            {
                return -1;
            }
        }

        public void Put(int key, int value)
        {
            if (cache.Count >= capacity && !cache.ContainsKey(key))
            {
                var oldestValue = history.First.Value;
                cache.Remove(oldestValue);
                history.Remove(oldestValue);
            }

            if (cache.ContainsKey(key))
            {
                history.Remove(key);
            }

            history.AddLast(key);
            cache[key] = value;
        }
    }
}
