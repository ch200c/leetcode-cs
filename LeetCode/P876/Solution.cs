using System.Collections.Generic;

namespace LeetCode.P876
{
    public class Solution
    {
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
