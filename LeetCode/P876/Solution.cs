using System.Collections.Generic;

namespace LeetCode.P876
{
    public class Solution
    {
        // Runtime: 84 ms (94.88 %)
        // Memory Usage: 23.8 MB
        public ListNode MiddleNode(ListNode head)
        {
            var nodes = new List<ListNode>();
            var current = head;
            while (current != null)
            {
                nodes.Add(current);
                current = current.next;
            }

            return nodes[nodes.Count / 2];
        }
    }
}
